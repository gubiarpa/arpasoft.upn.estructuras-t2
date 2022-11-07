namespace gubiarpa.estructuras_t2.core.Entities
{
    public class DoubleLinkedNode<T>
    {
        #region Attributes
        private readonly T? data;
        protected DoubleLinkedNode<T>? _previous;
        protected DoubleLinkedNode<T>? _next;
        #endregion

        #region Properties
        public T? Data => data;
        public DoubleLinkedNode<T>? Previous { get => _previous; set => _previous = value; }
        public DoubleLinkedNode<T>? Next { get => _next; set => _next = value; }
        #endregion

        #region Constructors
        public DoubleLinkedNode(T data)
        {
            data = data;
            _previous = _next = null;
        }

        public DoubleLinkedNode(T data, DoubleLinkedNode<T> previous, DoubleLinkedNode<T> next) : this(data)
        {
            Previous = previous;
            Next = next;
        }
        #endregion
    }
}
