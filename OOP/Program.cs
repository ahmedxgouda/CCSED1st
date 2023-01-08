namespace OOP
{
    class StudentProffesorTest
    {
        static void Main(string [] args)
        {
            Person man = new Person();
            man.Greet();
            Console.WriteLine();
            Student student = new Student();
            student.Greet();
            student.SetAge(15);
            student.ShowAge();
            student.Study();
            Console.WriteLine();
            Professor prof = new Professor();
            prof.Greet();
            prof.SetAge(50);
            prof.Explain();
        }
    }    
}