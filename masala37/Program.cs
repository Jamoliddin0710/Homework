var nums = Console.ReadLine()
.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int ichimlikraqami = nums[0];
int summa = nums[1];
if(ichimlikraqami == 1)
{
    Console.WriteLine($"Americano");
    summa -= 500;
}
else if(ichimlikraqami == 2)
{
    Console.WriteLine($"Caffe Lette");
    summa -= 400;
}
else if(ichimlikraqami == 3)
{
    Console.WriteLine($"Lemon Tea");
    summa -= 300;
}

Console.WriteLine($"{summa/500} {summa%500/100}");
