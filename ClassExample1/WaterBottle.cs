class WaterBottle
{
    private double _capacity;
    //private string _color;
    public double waterAmount;

    public double Capacity
    {
        get
        {
            return _capacity;
        }
        set
        {
            _capacity = value;
        }
    }
    

    public string Color { get; set; }
    
    //Constructor
    public WaterBottle()
    {
        Capacity = 100;
        Color = "Orange";
    }
    //Constructor Overloading
    public WaterBottle(double capacity, string color)
    {
        Capacity = capacity;
        Color = color;
    }

    //Method 
    public void AddWater(int Amount)
    {
        _capacity += Amount;
    }
    //Method Overloading
    public void AddWater(double Amount)
    {
        waterAmount += Amount;
    }

    public void AddWater(double Amount, bool waterflow)
    {
        if(waterflow)
        {
            if(_capacity > waterAmount)
            {
                _capacity = waterAmount;
            }
        }
        waterAmount += Amount;
    }
}

class Car
{
    public string model;
    public string color;
    public int year;
}


class Varsity
{
    public int Id = 1;
    public string Name = "Khan";
    public string Dept = "CSE";
    public double Salary = 125125;

    public void Details()
    {
        Console.WriteLine(Id);
        Console.WriteLine(Name);
        Console.WriteLine(Dept);
        Console.WriteLine(Salary);
    }

}