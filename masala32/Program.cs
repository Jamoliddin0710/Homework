var year = int.Parse(Console.ReadLine());
if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) )
{
    Console.WriteLine($"kabisa yilia ");
}

else
{
    Console.WriteLine($"kabisa yili emas ");
}
