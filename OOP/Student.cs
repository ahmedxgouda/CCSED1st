namespace OOP
{
    class Student : Person
    {
        public static void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is {0}", age);
        }
        public override void Greet()
        {
            Console.WriteLine("Hello, I'm a student");
        }
    }
}