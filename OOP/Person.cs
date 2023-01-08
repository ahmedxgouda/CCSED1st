namespace OOP
{
    class Person
    {

        private int age;
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return this.age;
        }
        
        public virtual void Greet()
        {
            Console.WriteLine("Hello, I'm just a normal person");
        }
    }
}