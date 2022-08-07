char belgi = char.Parse(Console.ReadLine());
if((belgi >= 'a' && belgi <= 'z'))
{
    Console.WriteLine(Convert.ToChar(belgi-32));
}
else if (belgi >= 'A' && belgi <= 'Z')
{
 Console.WriteLine(Convert.ToChar(belgi+32));   
}
else
{
    Console.WriteLine($"none");
}