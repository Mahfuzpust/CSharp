
int[] age = {20,10,20,30};
for(int i =0; i<age.Length; i++)
{
    Console.WriteLine(age[i]);
}
int[] value = new int[3];
value[0] = 1;
value[1] = 2;
value[2] = 3;
Console.WriteLine(value[2]);


int[,] multi = new int[3,3];



int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8  } };
Console.WriteLine(numbers[0, 0]);
Console.WriteLine(numbers[0, 2]);


String[] cars = { "Volvo", "BMW", "Mazda" };
Array.Sort(cars);
foreach(string i in cars)
{
    Console.WriteLine($"{i}");
}