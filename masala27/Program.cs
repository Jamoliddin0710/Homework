
public class Program
{
    public static void Main(string[] args)
{
var nums = Console.ReadLine()!.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

   int soat = nums[0];
   int minut = nums[1];
   soat += 24;
   if(minut < 45)
   {
    minut += 60;
    soat--;
   }
   minut -= 45;
   soat %= 24;
   Console.WriteLine($"{soat :D2} {minut:D2}");
   
}
}