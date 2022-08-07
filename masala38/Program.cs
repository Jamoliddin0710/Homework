var number = Console.ReadLine().
Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int max1 =  number[0] > number[1] ? number[0] : number[1];
var max = number[2] > max1 ? number[2] : max1; 
bool pifagorsonimi = ((Math.Pow(number[0],2) + Math.Pow(number[1],2) == 
Math.Pow(number[2],2)) || (Math.Pow(number[0],2) + Math.Pow(number[2],2) == 
Math.Pow(number[1],2)) || (Math.Pow(number[2],2) + Math.Pow(number[1],2) == 
Math.Pow(number[0],2)));

Console.WriteLine(pifagorsonimi);
