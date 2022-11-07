namespace gubiarpa.estructuras_t2.core.Entities
{
    public abstract class DoubleLinkedList<T>
    {
        #region Attributes
        protected DoubleLinkedNode<T>? _initial;
        protected DoubleLinkedNode<T>? _current;
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

        #region MainMethods
        /// <summary>
        /// Agrega un nodo con la información proveída en el parámetro 'data'
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
        /// Inserta un nodo, según un criterio de ordenación implementado en 'CompareTo'
        /// </summary>
        /// <param name="node"></param>
        public void Insert(DoubleLinkedNode<T> node)
        {
            var nodeRun = _initial;

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
        #endregion

        #region Helpers
        public abstract void Print();

        protected abstract int CompareTo(DoubleLinkedNode<T> nodeA, DoubleLinkedNode<T> nodeB);
        #endregion
    }
}
