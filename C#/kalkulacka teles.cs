bool teleso;

Console.WriteLine("vyber teleso(1=obvod kruhu 0= objem valce)" );
string s = Console.ReadLine();
if (s == "1")
{
    teleso = true;
}
else if (s == "0")
{
    teleso = false;
}
else
{
    Console.WriteLine("Neplatná volba!");
    return;
}
if (teleso == true) {
    double polomer;
    Console.WriteLine("zadej polomer");
    string polomerString = Console.ReadLine();
    polomer = Convert.ToDouble( polomerString );
    Console.WriteLine($"polomer je: {Math.PI * 2 * polomer} ");
    return;
}

if (teleso == false)
{
    double polomer;
    Console.WriteLine("zadej polomer");
    string polomerString = Console.ReadLine();
    polomer = Convert.ToDouble(polomerString);

    double vyska;
    Console.WriteLine("zadej vysku:");
   string vyskaString = Console.ReadLine();
    vyska = Convert.ToDouble( vyskaString );

    Console.WriteLine($"obsah valce je: {Math.PI * Math.Sqrt(polomer) * vyska}");
    return;

}