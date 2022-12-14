namespace Section8
{
    struct doctor
    {
        public string name { get; set; }
        public double salary { get; set; }
        public string department{ get; set; }



        public doctor(string _name, double _salary)
        {
            name = _name;
            salary = _salary;
            department = "General";
        }
        public doctor(string _name, double _salary, string _department)
        {
            name = _name;
            if (_salary >= 6000)
            {
                salary = 0.8 * _salary;
            }
            else
            {
                salary = _salary;
            }
            department = _department;
        }
        public override string ToString()
        {
            return $"Doctor's name: {name}, his salary: {salary}, and his department: {department}";
        }
    }
    class Program
    {

        
        static void Main()
        {
            doctor a = new doctor("Ahmed", 10000, "Surgery");
            doctor b = new doctor("Mohamed", 5000);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
        }
    }
}