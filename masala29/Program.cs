var arr = Console.ReadLine()
.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

if (arr[0] == Math.Pow(arr[1],2) )
{
    Console.WriteLine($"{arr[1]} * {arr[1]} = {arr[0]}");   
}
else if(arr[1] == Math.Pow(arr[0],2))
{
    Console.WriteLine($"{arr[0]} * {arr[0]} = {arr[1]}");   
}
else
{
    Console.WriteLine($"none");
}