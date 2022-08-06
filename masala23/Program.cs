char k = char.Parse(Console.ReadLine());
if((k > 'A' && k < 'Z') || (k > 'a' && k < 'z'))
{
    Console.WriteLine($"1");
}
else
{
  Console.WriteLine($"0");
}