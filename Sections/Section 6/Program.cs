namespace Section6
{
    class Factorial
    {
        internal long fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                Console.WriteLine("Math error.");
                return 0;
            }
            else
            {
                return n * fact(n - 1);
            }
        }
    }
    public class Program
    
    {
        static void Main(string[] args)
        {
            Factorial obj = new Factorial();
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {a} is {obj.fact(a)}");
        }       
    }
}