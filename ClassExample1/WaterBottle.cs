class WaterBottle
{
    private double _capacity;
    private string _color;
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
    

    public string Color
    {
        get
        {
            return _color;
        }
        set
        {
            _color = value;
        }
    }

    public WaterBottle(double capacity, string color)
    {
        _capacity = capacity;
        _color = color;
    }

    public void AddWater(int Amount)
    {
        _capacity += Amount;
    }
}