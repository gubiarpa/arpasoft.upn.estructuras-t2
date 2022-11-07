using gubiarpa.estructuras_t2.console_client.Operations;
using gubiarpa.estructuras_t2.core.Entities;

var doubleLinkedList = new DoubleLinkedStringList();

doubleLinkedList.Add(new DoubleLinkedNode<string>("Aries"));
doubleLinkedList.Add(new DoubleLinkedNode<string>("Tauro"));
doubleLinkedList.Add(new DoubleLinkedNode<string>("Géminis"));
doubleLinkedList.Insert(new DoubleLinkedNode<string>("Cáncer"));
doubleLinkedList.Insert(new DoubleLinkedNode<string>("Leo"));

doubleLinkedList.Print();

Console.WriteLine($"Cantidad de Elementos: {doubleLinkedList.GetLength()}");

var position = 3;
var nodeFounded = doubleLinkedList.SearchByPosition(position);
Console.WriteLine($"Position: {position} => {nodeFounded.Data}");
