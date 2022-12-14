namespace Task6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The cube is {Cube(num)}");
        }
        private static double Cube(double n)
        {
            return n * n * n;
        }
    }
}