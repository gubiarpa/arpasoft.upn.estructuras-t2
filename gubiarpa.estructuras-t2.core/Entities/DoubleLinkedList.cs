namespace gubiarpa.estructuras_t2.core.Entities
{
    public class DoubleLinkedList<T>
    {
        #region Attributes
        private DoubleLinkedNode<T>? _initial;
        private DoubleLinkedNode<T>? _final;
        #endregion

        #region Constructor
        public DoubleLinkedList()
        {
            _initial = _final = null;
        }

        public DoubleLinkedList(T data)
        {
            _initial = _final = new DoubleLinkedNode<T>(data);
        }
        #endregion

        #region MainMethods
        #endregion
    }
}
