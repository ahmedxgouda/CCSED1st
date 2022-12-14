namespace Task7
{
    class Program
    {
        static void Main()
        {
            double [,] arr = new double [4, 4];
            double sum, product;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Enter element[{i + 1}, {j + 1}]: ");
                    arr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Multiply(ref arr, out sum, out product);
            Console.WriteLine($"Sum: {sum}, Product: {product}");
        }
        public static void Multiply(ref double [,] arr, out double sum, out double product)
        {
            sum = 0;
            product = 1;
            int rowsLength = arr.GetLength(0);
            int colsLength = arr.GetLength(1);
            for (int i = 0; i < rowsLength; i++)
            {
                for (int j = 0; j < colsLength; j++)
                {
                    sum += arr[i, j];
                    product *= arr[i, j];
                }
            }
        }
    }
}