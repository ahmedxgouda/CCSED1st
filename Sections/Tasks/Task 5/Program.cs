using System.Text;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            StringBuilder name = new StringBuilder("Ahmed");
            name.Append(" Mosad");
            name.Append(" Ali");
            name.Append(" Ahmed");
            name.Append(" Gouda");
            Console.WriteLine(name);
        }
    }
}