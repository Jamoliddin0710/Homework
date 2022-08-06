var num = Console.ReadLine().
Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var a = num[0];
var b = num[1];

Console.WriteLine($"Area is {a*b}");
