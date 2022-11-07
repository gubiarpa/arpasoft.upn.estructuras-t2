using gubiarpa.estructuras_t2.console_client.Operations;
using gubiarpa.estructuras_t2.core.Entities;

var doubleLinkedList = new DoubleLinkedStringList();

doubleLinkedList.Add("Aries");
doubleLinkedList.Add("Tauro");
doubleLinkedList.Add("Géminis");
doubleLinkedList.Add("Cáncer");

doubleLinkedList.Insert(new DoubleLinkedNode<string>("Leo"));

doubleLinkedList.Print();
