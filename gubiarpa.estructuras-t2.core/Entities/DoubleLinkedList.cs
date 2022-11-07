namespace gubiarpa.estructuras_t2.core.Entities
{
    public abstract class DoubleLinkedList<T>
    {
        #region Attributes
        protected DoubleLinkedNode<T>? _initial;
        protected DoubleLinkedNode<T>? _current;
        #endregion

        #region Properties
        public DoubleLinkedNode<T>? Initial { get => _initial; }
        #endregion

        #region Constructor
        public DoubleLinkedList()
        {
            _initial = _current = null;
        }

        public DoubleLinkedList(T data)
        {
            _initial = _current = new DoubleLinkedNode<T>(data);
        }
        #endregion

        #region Evaluation-T2
        public double Compare(DoubleLinkedList<T> anotherDoubleLinkedList)
        {
            /// 1. Validamos que ambas listas tengan la misma longitud
            var length1 = GetLength();
            var length2 = anotherDoubleLinkedList.GetLength();
            if (length1 != length2)
                return 0; // Ninguna coincidencia

            /// 2. Recorremos todos los nodos
            DoubleLinkedNode<T>? nodeRunA = _initial;
            DoubleLinkedNode<T>? nodeRunB = anotherDoubleLinkedList.Initial!;
            double matchFactor = 0; // % de coincidencia

            while (nodeRunA != null)
            {
                if (Equals(nodeRunA, nodeRunB))
                {
                    matchFactor++;
                }

                nodeRunA = nodeRunA?.Next;
                nodeRunB = nodeRunB?.Next;
            }

            return matchFactor / length1;
        }

        public void SelectionSort()
        {
            var listLength = GetLength();

            for (int i = 1; i <= listLength - 1; i++)
            {
                int minimum = i;

                for (int j = i + 1; j <= listLength; j++)
                {
                    var nodeA = SearchByPosition(j);
                    var nodeB = SearchByPosition(minimum);

                    if (CompareTo(nodeA, nodeB) < 0)
                    {
                        minimum = j;
                    }
                }
                Exchange(i, minimum);
            }
        }
        #endregion

        #region MainMethods
        /// <summary>
        /// Agrega un nodo con la información proveída en el parámetro 'data'.
        /// </summary>
        /// <param name="data">Información del Nodo - Genérico</param>
        public void Add(DoubleLinkedNode<T> node)
        {
            if (_current == null)
            {
                _initial = _current = node;
            }
            else
            {
                node.Previous = _current;
                _current.Next = node;
                _current = node;
            }
        }

        /// <summary>
        /// Agrega un nodo, pero solamente con la información (data).
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            Add(new DoubleLinkedNode<T>(data));
        }

        /// <summary>
        /// Inserta un nodo, según un criterio de ordenación implementado en 'CompareTo'.
        /// </summary>
        /// <param name="node"></param>
        public void Insert(DoubleLinkedNode<T> node)
        {
            var nodeRun = Initial;

            /// Find insertion position
            while (nodeRun != null)
            {
                if (CompareTo(node, nodeRun) < 0)
                    break;

                nodeRun = nodeRun.Next;
            }

            /// Node Insertion
            if (nodeRun == null)
            {
                Add(node);
            }
            else
            {
                if (nodeRun.Previous == null)
                {
                    _initial = node;
                    node.Next = nodeRun;
                    nodeRun.Previous = node;
                }
                else
                {
                    nodeRun.Previous.Next = node;
                    node.Previous = nodeRun.Previous;
                    node.Next = nodeRun;
                    nodeRun.Previous = node;
                }
            }
        }

        /// <summary>
        /// Obtiene el número de elementos de la lista.
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            var nodeRun = _initial;
            int countElements = 0;

            while (nodeRun != null)
            {
                countElements++;
                nodeRun = nodeRun.Next;
            }

            return countElements;
        }

        /// <summary>
        /// Busca elemento por posición.
        /// </summary>
        /// <param name="position">Posición buscada</param>
        /// <returns></returns>
        public DoubleLinkedNode<T> SearchByPosition(int position)
        {
            DoubleLinkedNode<T> nodeFounded, nodeReference;

            nodeReference = _initial!;
            nodeFounded = null;
            int i = 0;

            while (nodeReference != null)
            {
                i++;

                if (i == position)
                {
                    nodeFounded = nodeReference;
                    break;
                }

                nodeReference = nodeReference.Next!;
            }

            return nodeFounded;
        }

        /// <summary>
        /// Intercambia dos nodos, según la posición especificada.
        /// </summary>
        /// <param name="positionA">Posición 1</param>
        /// <param name="positionB">Posición 2</param>
        public void Exchange(int positionA, int positionB)
        {
            DoubleLinkedNode<T> nodeA, nodeB, nodeTemporal;

            int countElements = GetLength();

            if (
                (positionA >= 1 && positionA <= countElements) &&
                (positionB >= 1 && positionB <= countElements) &&
                (positionA < positionB)
            )
            {
                nodeA = SearchByPosition(positionA);
                nodeB = SearchByPosition(positionB);

                nodeTemporal = new DoubleLinkedNode<T>(nodeA.Previous!, nodeA.Next!);

                Move((positionA == positionB - 1) ? nodeB : nodeB.Previous!, nodeA, nodeB.Next!);
                Move(nodeTemporal.Previous!, nodeB, (positionA == positionB - 1) ? nodeA : nodeTemporal.Next!);

                if (nodeA == Initial)
                {
                    _initial = nodeB;
                }
                else if (nodeB == Initial)
                {
                    _initial = nodeA;
                }

                if (nodeA == _current)
                {
                    _current = nodeB;
                }
                else
                {
                    _current = nodeA;
                }
            }
        }
        #endregion

        #region Utils
        /// <summary>
        /// Mueve la posición entre dos nodos
        /// </summary>
        /// <param name="nodePrevious">Nodo anterior</param>
        /// <param name="nodeExchanged">Nodo de intercambio</param>
        /// <param name="nodeNext">Nodo siguiente</param>
        protected void Move(DoubleLinkedNode<T> nodePrevious, DoubleLinkedNode<T> nodeExchanged, DoubleLinkedNode<T> nodeNext)
        {
            if (nodePrevious != null)
            {
                nodePrevious.Next = nodeExchanged;
            }

            nodeExchanged.Previous = nodePrevious;

            if (nodeNext != null)
            {
                nodeNext.Previous = nodeExchanged;
            }

            nodeExchanged.Next = nodeNext;
        }
        #endregion

        #region Abstract
        /// <summary>
        /// Imprime todos los elementos de la lista.
        /// </summary>
        public abstract void Print();

        /// <summary>
        /// Compara dos nodos. Si el primero es mayor, 1; si empata, 0; si el segundo es mayor, -1.
        /// </summary>
        /// <param name="nodeA">Primer nodo</param>
        /// <param name="nodeB">Segundo nodo</param>
        /// <returns></returns>
        protected abstract int CompareTo(DoubleLinkedNode<T> nodeA, DoubleLinkedNode<T> nodeB);

        /// <summary>
        /// Compara el valor de dos nodos, devolviendo true/false si son valores iguales.
        /// </summary>
        /// <param name="nodeA">Nodo 1</param>
        /// <param name="nodeB">Nodo 2</param>
        /// <returns></returns>
        protected abstract bool Equals(DoubleLinkedNode<T>? nodeA, DoubleLinkedNode<T>? nodeB);
        #endregion
    }
}
