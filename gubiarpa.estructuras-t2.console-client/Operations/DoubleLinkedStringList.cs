using gubiarpa.estructuras_t2.core.Entities;

namespace gubiarpa.estructuras_t2.console_client.Operations
{
    public class DoubleLinkedStringList : DoubleLinkedList<string>
    {
        public override void Print()
        {
            var nodeRun = Initial;

            while (nodeRun != null)
            {
                Console.WriteLine(nodeRun?.Data);
                nodeRun = nodeRun?.Next;
            }
        }

        protected override int CompareTo(DoubleLinkedNode<string> nodeA, DoubleLinkedNode<string> nodeB)
        {
            return string.Compare(nodeA?.Data, nodeB?.Data);
        }

        protected override bool Equals(DoubleLinkedNode<string>? nodeA, DoubleLinkedNode<string>? nodeB)
        {
            if (nodeA == null || nodeB == null)
                return false;

            if (nodeA.Data == null || nodeB.Data == null)
                return false;

            return nodeA.Data.Equals(nodeB.Data);
        }
    }
}
