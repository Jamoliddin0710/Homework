var num = Console.ReadLine()
.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(Double.Parse).ToArray();
char belgi = char.Parse(Console.ReadLine());
if(belgi == '+')
{
    Console.WriteLine($"{num[0]}+{num[1]}={num[0]+num[1]}");    
}

if(belgi == '-')
{
    Console.WriteLine($"{num[0]}-{num[1]}={num[0]-num[1]}");    
}


if(belgi == '*')
{
    Console.WriteLine($"{num[0]}*{num[1]}={num[0]*num[1]}");    
}


if(belgi == '/')
{
    Console.WriteLine($"{num[0]}/{num[1]}={num[0]/num[1]}");    
}
