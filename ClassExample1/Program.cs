

WaterBottle bottle1 = new WaterBottle(1000, "red");
bottle1.AddWater(100);

Console.WriteLine(bottle1.Capacity);
Console.WriteLine(bottle1.Color);

WaterBottle bottle2 = new WaterBottle(2000, "Blue");
bottle2.AddWater(200);
bottle2.AddWater(300.5, true);

Console.WriteLine(bottle2.Capacity);
Console.WriteLine(bottle2.Color);


Car ob1 = new Car();
ob1.model = "BMW";
ob1.color = "blue";
ob1.year = 1;

Car ob2 = new Car();
ob2.model = "Marcides";
ob2.color = "Red";
ob2.year = 2;

Console.WriteLine(ob1.model);
Console.WriteLine(ob2.model);


Varsity v1 = new Varsity();
v1.Details();

Varsity v2 = new Varsity();
v2.Details();

