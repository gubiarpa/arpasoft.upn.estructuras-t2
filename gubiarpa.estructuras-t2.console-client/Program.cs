using gubiarpa.estructuras_t2.console_client.Operations;
using gubiarpa.estructuras_t2.core.Entities;

Console.WriteLine("\n** Pokemon - Lista 1 **");
var pokemonLinkedList1 = new DoubleLinkedStringList();
pokemonLinkedList1.Add(new DoubleLinkedNode<string>("Charmander"));
pokemonLinkedList1.Add(new DoubleLinkedNode<string>("Squirtle"));
pokemonLinkedList1.Add(new DoubleLinkedNode<string>("Bulbasaur"));
pokemonLinkedList1.Add(new DoubleLinkedNode<string>("Picachu"));
pokemonLinkedList1.Print();

Console.WriteLine("\n** Pokemon - Lista 2 **");
var pokemonLinkedList2 = new DoubleLinkedStringList();
pokemonLinkedList2.Add(new DoubleLinkedNode<string>("Butterfly"));
pokemonLinkedList2.Add(new DoubleLinkedNode<string>("Squirtle"));
pokemonLinkedList2.Add(new DoubleLinkedNode<string>("Ivisaur"));
pokemonLinkedList2.Add(new DoubleLinkedNode<string>("Picachu"));
pokemonLinkedList2.Print();

#region Pregunta1
var matchPercentage = pokemonLinkedList1.Compare(pokemonLinkedList2);
Console.WriteLine($"\n>> % Coincidencia: {(matchPercentage * 100)}%");
#endregion
