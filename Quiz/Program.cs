int num = 5;
if (num == 2)
{
    Console.WriteLine("1 and 2");
}
else if (num == 5)
{
    Console.WriteLine("5");
}
// switch (num)
// {
//     case 2:
//         Console.WriteLine("1 and 2");
//         break;
//     case 5:
//         Console.WriteLine("5");
//         break;
// }
Console.WriteLine(num == 2 ? "1 and 2" : num == 5 ? "5" : null);