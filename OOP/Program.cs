namespace OOP
{
    static class StudentProffesorTest
    {
        static void Main()
        {
            // person
            Person man = new();
            man.Greet();
            Console.WriteLine();
            // student
            Student student = new();
            student.Greet();
            student.SetAge(15);
            student.ShowAge();
            Student.Study();
            Console.WriteLine();
            // professor
            Professor prof = new();
            prof.Greet();
            prof.SetAge(50);
            Professor.Explain();
        }
    }
}