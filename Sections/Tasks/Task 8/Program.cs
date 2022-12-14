namespace Task8
{
    public struct Cars
    {
        public string brand;
        public double price;
        public int year;
        public Cars(string _brand, double _price, int _year)
        {
            brand = _brand;
            price = _price;
            year = _year;
        }
        public Cars(string _brand, double _price)
        {
            brand = _brand;
            price = _price;
            year = 2011;
        }
        public void Display()
        {
            Console.WriteLine($"The car's brand is {brand}, its price is {price}, and its year is {year}");
        }
    }
    class Program
    {
        static void Main()
        {
            Cars car1 = new Cars("KIA", 400000);
            Cars car2 = new Cars("BYD", 700000, 2022);
            car1.Display();
            car2.Display();
        }
    }
}