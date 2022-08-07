var num = Console.ReadLine().
Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(ulong.Parse).ToArray();

System.Console.WriteLine
(Math.Pow(num[0],3) + Math.Pow(num[1],3) + Math.Pow(num[2],3));