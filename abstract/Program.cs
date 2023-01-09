namespace Abstract
{
    class Calculator
    {
        public int num;
        public Calculator(int num)
        {
            this.num = num;
        }
        public Calculator()
        {
            this.num = 0;
        }
        public static Calculator operator +(Calculator calc1, Calculator calc2)
        {
            Calculator calc3 = new Calculator(0);
            calc3.num = calc1.num + calc2.num;
            return calc3;

        }
        public void Display()
        {
            Console.WriteLine(num);
        }
    }
    abstract class Vehicle
    {
        public abstract void Display();
        public abstract int num { get; set; }
    }
    class Bus : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("Bussssssssss!");
        }
        public override int num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
    }
    class Car : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("Carrrrrrrrrrr!");
        }
        public override int num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            Vehicle car = new Car();
            Vehicle bus = new Bus();
            car.Display();
            bus.Display();
            Calculator num1 = new Calculator(200);
            Calculator num2 = new Calculator(20);
            Calculator num3 = new Calculator();
            num3 = num1 + num2;
            num1.Display();
            num2.Display();
            num3.Display();
        }
    }
}