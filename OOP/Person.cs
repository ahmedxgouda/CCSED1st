namespace OOP
{
    class Person
    {
        protected int age;
        public void SetAge(int age)
        {
            this.age = age;
        }

        public virtual void Greet()
        {
            Console.WriteLine("Hello, I'm just a normal person");
        }
    }
}