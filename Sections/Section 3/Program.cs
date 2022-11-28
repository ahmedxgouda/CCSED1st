// See https://aka.ms/new-console-template for more information
Console.Write("Enter the first number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the second number: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What do you want to do?");
Console.WriteLine("1- Get the summation\n2- Substract the second number from the first");
Console.WriteLine("3- Multiply each other\n4- Divide the first by the second");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        Console.WriteLine("{0}", a + b);
        break;
    case 2:
        Console.WriteLine("{0}", a - b);
        break;
    case 3:
        Console.WriteLine("{0}", a * b);
        break;
    case 4:
        Console.WriteLine("{0}", a / b);
        break;
        
}
