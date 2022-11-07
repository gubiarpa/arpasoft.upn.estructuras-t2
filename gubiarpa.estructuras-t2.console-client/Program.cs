using gubiarpa.estructuras_t2.console_client.Operations;

#region DataCook
Console.WriteLine("\n** Pokemon - Lista 1 **");
var pokemonLinkedList1 = new DoubleLinkedStringList();
pokemonLinkedList1.Add("Charmander");
pokemonLinkedList1.Add("Squirtle");
pokemonLinkedList1.Add("Bulbasaur");
pokemonLinkedList1.Add("Picachu");
pokemonLinkedList1.Print();

Console.WriteLine("\n** Pokemon - Lista 2 **");
var pokemonLinkedList2 = new DoubleLinkedStringList();
pokemonLinkedList2.Add("Zubat");
pokemonLinkedList2.Add("Squirtle");
pokemonLinkedList2.Add("Ivisaur");
pokemonLinkedList2.Add("Picachu");
pokemonLinkedList2.Print();
#endregion

#region Pregunta1
var matchPercentage = pokemonLinkedList1.Compare(pokemonLinkedList2);
Console.WriteLine($"\n>> % Coincidencia: {(matchPercentage * 100)}%");
#endregion

#region Pregunta2
Console.WriteLine("\n** Pokemon - Lista 1 - Sorted **");
pokemonLinkedList1.SelectionSort();
pokemonLinkedList1.Print();

Console.WriteLine("\n** Pokemon - Lista 2 - Sorted **");
pokemonLinkedList2.SelectionSort();
pokemonLinkedList2.Print();
#endregion
