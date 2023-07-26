class Car
{
    public void result()
    {
        Console.WriteLine("New value");
    }
}

class Item
{
    public void Display(int id, string name, int value=2)
    {
        Console.WriteLine($"{name} , {id} , {value}");

        Console.WriteLine($"{name} , {id}, {value}");
    }

   
}

class Bottle
{
    public int Data(int x, int y)
    {
        return x + y;
    }

    public double Data(double x, double y)
    {
        return x + y;
    }
}






