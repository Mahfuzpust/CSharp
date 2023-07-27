
using System.Collections;

ArrayList myList = new ArrayList();
myList.Add(1);
myList.Add("Mahfuz");
myList.Add(2.2);
myList.Add(52.55555);
myList.Add("Raj");

//myList.RemoveAt(0);
myList.Add(myList.Count);

foreach (var data in myList)
{
    Console.WriteLine(data);
}

Console.WriteLine("\n");

List<string> myList1 = new List<string>();

myList1.Add("Mahfuz");

foreach (var data in myList1)
{
    Console.WriteLine($"{data}");
}

List<int> myList2 = new List<int>();

myList2.Add(50);
myList2.Add(20);
myList2.Add(500);
myList2.Add(2);

myList2.Sort();

foreach (var data in myList2)
{
    Console.WriteLine(data);
}
