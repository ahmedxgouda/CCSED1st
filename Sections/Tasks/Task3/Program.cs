int sum = 0;
double i;
for (i = 0; i < 10; i++)
{
    string order = i == 0 ? "st" : i == 1 ? "nd" : i == 2 ? "rd" : "th";
    Console.Write($"Enter the {i + 1}{order} number: ");
    sum += Convert.ToInt32(Console.ReadLine());
}
double average = sum / i;

Console.WriteLine($"Sum: {sum}\tAverage: {average}");