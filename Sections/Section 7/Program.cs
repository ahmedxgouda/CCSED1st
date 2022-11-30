namespace Section7
{
    class Program
    {
        static void Vector(out int max, out int min, params int [] input)
        {
            max = 0;
            // assigning min to the first element of the array not 0
            min = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
                if (input[i] < min)
                {
                    min = input[i];
                }
            }
        }
        static void Main()
        {
            Console.Write("How many numbers do you want to type? ");
            int count = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int [count];
            int max, min;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter number[{i + 1}]: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Vector(out max, out min, arr);
            Console.WriteLine($"Max: {max}\nMin: {min}");
        }
        
    }
}