var second = int.Parse(Console.ReadLine());
Console.WriteLine($"{(second/3600):D2}:{(second%3600/60):D2}:{(second%3600%60):D2}");
