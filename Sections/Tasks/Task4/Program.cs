int[,] arr = new int [3,3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Enter Element[{i}, {j}]: ");
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}
double sum = 0;
double count = 0;
for (int k = 0; k < 3; k++)
{
    for(int l = 0; l < 3; l++)
    {
        sum += arr[k, l];
        count++;
    }
}

double average = sum / count;
Console.WriteLine($"Average of matrix is: {average}");