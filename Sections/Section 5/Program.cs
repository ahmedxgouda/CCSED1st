int [][]arr = new int [3][];

for (int i = 0; i < 3; i++)
{
    Console.Write("Enter arr[{0}] size: ", i);

    int size = Convert.ToInt32(Console.ReadLine());
    arr[i] = new int [size];
    for (int j = 0; j < size; j++)
    {
        Console.Write("Enter Element[{0}][{1}]", i, j);
        arr[i][j] = Convert.ToInt32(Console.ReadLine());
    }
    
}

for (int k = 0; k < 3; k++)
{
    Console.WriteLine("arr[{0}]", k);
    for (int m = 0; m < arr[k].Length; m++)
    {
        Console.Write(arr[k][m]);
        Console.Write("\t");
    }
    Console.WriteLine();
}