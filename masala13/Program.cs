var nums = Console.ReadLine()
.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(Double.Parse).ToArray();

Console.WriteLine($"{(nums[0] * nums[1]):F2}");
