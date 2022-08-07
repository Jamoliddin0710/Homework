
bool faktorialmi= false;
ulong son =  ulong.Parse(Console.ReadLine()!);
ulong faktorial = 1;
for (ulong i = 1; i  <= son ; i++)
{
    faktorial *= i;
    if(son == faktorial){ faktorialmi = true;
        break;
    }
}
Console.WriteLine(faktorialmi);

