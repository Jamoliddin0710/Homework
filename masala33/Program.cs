int son = int.Parse(Console.ReadLine());
int tahmin = int.Parse(Console.ReadLine());
if(son == tahmin)
{
    Console.WriteLine($"Yorvordiz");
}
////
else if( son > tahmin)
{
    Console.WriteLine($"Tepaga");

     tahmin = int.Parse(Console.ReadLine());
    if(son == tahmin)
{
    Console.WriteLine($"Yorvordiz");
}
else if( son > tahmin)
{
    Console.WriteLine($"Tepaga");
    

}
else
if( son < tahmin )
{
    Console.WriteLine($"Pastga");

}

    

}

////
else
if( son < tahmin )
{
    Console.WriteLine($"Pastga");
     tahmin = int.Parse(Console.ReadLine());
    if(son == tahmin)
{
    Console.WriteLine($"Yorvordiz");
}
else if( son > tahmin)
{
    Console.WriteLine($"Tepaga");
    

}
else
if( son < tahmin )
{
    Console.WriteLine($"Pastga");

}
////

}
