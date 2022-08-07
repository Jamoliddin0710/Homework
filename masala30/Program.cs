var arr = Console.ReadLine()
.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var katta1 = (arr[0] > arr[1] ? arr[0] : arr[1]);
var katta2 = (katta1 > arr[2] ? katta1 : arr[2]);
Console.WriteLine(katta2);
