// See https://aka.ms/new-console-template for more information
int[,] arr = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("Enter Element[{0}, {1}]: ", i, j);
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    //Console.WriteLine();
    
}
Console.WriteLine("Before: ");
for (int k = 0; k < 3; k++)
{
    for (int l = 0; l < 3; l++)
    {
        Console.Write(arr[k, l]);
        Console.Write("\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\nAfter: ");
for (int m = 0; m < 3; m++)
{
    for (int n = 0; n < 3; n++)
    {
        Console.Write(2 * arr[m, n]);
        Console.Write("\t");
    }
    Console.WriteLine();
}
