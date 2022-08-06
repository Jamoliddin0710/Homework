var s = int.Parse(Console.ReadLine());
int l = s % 1000/100;
if(l <= 5)
{
Console.WriteLine($"{s / 1000 * 1000}");
}
else
{
    Console.WriteLine($"{(s/1000 + 1) * 1000}");
}