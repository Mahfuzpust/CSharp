
string name = "";
string location = "Sherpur";

if (String.IsNullOrEmpty(name))
{

}

if(name ==null || name == string.Empty)
{
    Console.WriteLine("Yes");
}
else
{
    Console.Write(name);
}


if (string.IsNullOrEmpty(location))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine($"{location}");
}

Console.WriteLine(char.IsLetter('4'));
Console.WriteLine(location.IndexOf('p'));


string a = "mahfuz";
string b = "mahfuzz";

Console.WriteLine(string.Compare(a, b));



