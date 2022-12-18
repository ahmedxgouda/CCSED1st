namespace Task9
{
    struct Students
    {
        int id;
        string name;
        string gender;
        Courses[] StudentCourses;
        public Students(int _id, string _name, string _gender, Courses[] courses)
        {
            id = _id;
            name = _name;
            gender = _gender;
            StudentCourses = courses;
            Console.WriteLine("----Student data----");
            Console.WriteLine($"Name: {name}, ID: {id}, Gender: {gender}");
            Console.WriteLine("----Courses----");
        }
    }
    struct Courses
    {
        public int code;
        public string name; 
        public char degree;
        public Courses(int _code, string _name, char _degree)
        {
            code = _code;
            name = _name;
            degree = _degree;   
        }
        
    }
    class Program
    {
        static void Main()
        {
            Courses[] courses1 =
            {
                new Courses(4545454, "Math3", 'A'), new Courses(184851, "C#", 'B'),
                new Courses(84489, "Control", 'C'), new Courses(158815, "OS", 'A')
            };

            Courses[] courses2 =
            {
                new Courses(4545454, "Math3", 'B'), new Courses(184851, "C#", 'A'),
                new Courses(84489, "Control", 'D'), new Courses(158815, "OS", 'C')
            };

            Students student1 = new Students(10444000, "Ahmed Mossad", "Male", courses1);
            Print(courses1);
            Students student2 = new Students(10234500, "Mohamed Ali", "Male", courses2);
            Print(courses2);
        }
        public static void Print(Courses[] courses)
        {
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine($"----Course {i + 1}----");
                Console.WriteLine($"Name: {courses[i].name}, code: {courses[i].code}, degree: {courses[i].degree}");
            }
        }
    }
}