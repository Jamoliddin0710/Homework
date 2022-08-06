var nums = Console.ReadLine()!.
Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
if(nums[0]>nums[1]) 
{
    Console.WriteLine($"{nums[0]/nums[1]} {nums[0]%nums[1]}");
}
else
{
    Console.WriteLine($"{nums[1]/nums[0]} {nums[1]%nums[0]}");
}