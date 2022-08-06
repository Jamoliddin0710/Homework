int f1 = 0 ;
int f2 = 1;
int f;
Console.Write($"{f1} ");
Console.Write($"{f2} ");
for (int i = 0; i < 8 ; i++)
{
    f = f1 + f2;
    Console.Write($"{f} ");
     f1 = f2;
     f2 = f ;
}
