using gubiarpa.estructuras_t2.core.Entities;

namespace gubiarpa.estructuras_t2.console_client.Operations
{
    public class DoubleLinkedStringList : DoubleLinkedList<string>
    {
        public override void Print()
        {
            var nodeRun = _initial;

            while (nodeRun != null)
            {
                Console.WriteLine(nodeRun?.Data);
                nodeRun = nodeRun?.Next;
            }
        }
    }
}
