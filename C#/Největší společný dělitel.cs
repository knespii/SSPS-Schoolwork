string errorMsg = "";
bool error = false;
int x = 0;
int y = 0;

static int NSD(int x, int y)
{
    while (y != 0)
    {
        int zbytek = x % y;
        x = y;
        y = zbytek;
    }
    return x;
}


Console.WriteLine("zadejte první číslo (X): ");
string s = Console.ReadLine();
if (s == null || s.Length == 0)
{
    error = true;
    errorMsg = "První číslo nebylo zadáno";
}
else
    x = int.Parse(s);


Console.WriteLine("Zadejte druhé číslo (Y): ");
s = Console.ReadLine();
if (s == null || s.Length == 0)
{
    error = true;
    if (errorMsg.Length > 0)
    {
        errorMsg += ", ";
    }
    errorMsg += "Druhé číslo nebylo zadáno";

}
else
{
    y = int.Parse(s);
}

if (error == false)
{
    int nsd = NSD(x, y);
    Console.WriteLine($"Nejvetsi spolecny delitej {x} a {y} je: {nsd}");
}
else
{
    Console.WriteLine("Došlo k chybě");
    Console.WriteLine(errorMsg);
}

