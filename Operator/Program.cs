
using System;

int a = 10;
Console.WriteLine(a);
Console.WriteLine(a++);
Console.WriteLine(a);

Console.WriteLine(0.1m * 20.1m);
Console.WriteLine(11 / -2);

Console.WriteLine(15.5f/ 2f);

Console.WriteLine(16.8f / 4.1f); 
Console.WriteLine(16.8d / 4.1d); 
Console.WriteLine(16.8m / 4.1m);

Console.WriteLine(-5.2f % 2.0f); 
Console.WriteLine(5.9 % 3.1); 
Console.WriteLine(5.9m % 3.1m); 

Console.WriteLine(5 % -2);

int x = 5;
x = ~x;



int? m = null;
m = 5;
Console.WriteLine($"The value: {m.Value}");

Console.WriteLine($"The Hasvalue: {m.HasValue}");


string name = "";
string text = name ?? "N/A";
Console.WriteLine(text);

int v1 = 4;
int v2 = 3;
string v = v1 > v2 ? "yes" : "no";
Console.WriteLine(v);
string vv = v1 < v2 ? "yes" : "no";
Console.WriteLine(vv);



