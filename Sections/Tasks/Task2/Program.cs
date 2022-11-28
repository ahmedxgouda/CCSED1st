Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());


int smallest = (a < b && a < c) ? a : (b < a && b < c) ? b : c;

Console.WriteLine($"Smallest: {smallest}");