namespace gubiarpa.estructuras_t2.core.Entities
{
    public abstract class DoubleLinkedList<T>
    {
        #region Attributes
        private DoubleLinkedNode<T>? _initial;
        private DoubleLinkedNode<T>? _current;
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
        public void Add(T data)
        {
            var node = new DoubleLinkedNode<T>(data);

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
        #endregion

        #region Helpers
        public abstract void Print();
        #endregion
    }
}
