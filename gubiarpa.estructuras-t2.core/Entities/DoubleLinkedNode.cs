namespace gubiarpa.estructuras_t2.core.Entities
{
    public class DoubleLinkedNode<T>
    {
        #region Attributes
        private T? _element;
        private DoubleLinkedNode<T>? _previous;
        public DoubleLinkedNode<T>? _next;
        #endregion

        #region Constructors
        public DoubleLinkedNode(T element)
        {
            _element = element;
        }

        public DoubleLinkedNode(T element, DoubleLinkedNode<T> previous, DoubleLinkedNode<T> next) : this(element)
        {
            _previous = previous;
            _next = next;
        }
        #endregion
    }
}
