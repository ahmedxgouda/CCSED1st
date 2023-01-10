namespace OOP
{
    class Professor : Person
    {
        public static void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
        public override void Greet()
        {
            Console.WriteLine("Hello, I'm a proffesor");
        }
    }
}