using System;
using System.Collections.Generic;

LinkedList<String> linkList1 = new LinkedList<String>();

//The LinkedList needs to be able to Add new Nodes to the List
linkList1.AddLast("First");
linkList1.AddLast("Second");
linkList1.AddLast("Third");

//The Node needs the ability to print its own data
Console.WriteLine(linkList1.First.Value);
Console.WriteLine(linkList1.Last.Value);

//The LinkedList needs to be able to print the data of all of its Nodes in sequence
foreach(String s in linkList1)
{
	Console.WriteLine(s);
}


LinkedList<int> linkList2 = new LinkedList<int>();
linkList2.AddLast(1);
linkList2.AddLast(2);
linkList2.AddLast(3);

Console.WriteLine(linkList2.First.Value);
Console.WriteLine(linkList2.Last.Value);

foreach (int i in linkList2)
{
	Console.WriteLine(i);
}