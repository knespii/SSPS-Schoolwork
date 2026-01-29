Console.WriteLine("zadej prvni cislo");
string s1 = Console.ReadLine();
int cislo1 = Convert.ToInt32(s1);

Console.WriteLine("zadej druhe cislo");
string s2 = Console.ReadLine();
int cislo2 = Convert.ToInt32(s2);

Console.WriteLine("zadej operator");
string operatorr = Console.ReadLine();

if (operatorr == "+")
{
    Console.WriteLine(cislo1 + cislo2);
}
else if (operatorr == "-")
{
    Console.WriteLine(cislo1 - cislo2);
}
else if (operatorr == "*")
{
    Console.WriteLine(cislo1 * cislo2);
}
else if (operatorr == "/") 
{
Console.Write(cislo1 / cislo2);
}
else{
    Console.WriteLine("spatne zadany operator");
}