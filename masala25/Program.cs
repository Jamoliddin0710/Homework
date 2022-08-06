var num = Console.ReadLine()!.
Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

 Console.WriteLine(num[0] > num[1]?num[0]:num[1]);
    
