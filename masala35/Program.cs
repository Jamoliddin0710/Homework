int  strike = 0 , ball = 0 ;
var s = Console.ReadLine()
.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

var t = Console.ReadLine()
.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
////1
if(t[0] == s[0])
{
    strike++;
}
else if(t[0] == s[1] || t[0] == s[2])
{
    ball++;
}
////2
if(t[1] == s[1])
{
    strike++;
}
else if(t[1] == s[0] || t[1] == s[2])
{
    ball++;
}
////3
if(t[2] == s[2])
{
    strike++;
}
else if(t[2] == s[0] || t[2] == s[1])
{
    ball++;
}

Console.WriteLine($"{strike}S{ball}B");
