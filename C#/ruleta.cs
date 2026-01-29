Console.WriteLine("vlozte sazku");
string i = Console.ReadLine();
Random rnd = new Random();
int num = rnd.Next(1, 100);

if (num < 50)
{
    Console.WriteLine("vyhral jsi");
}else
{ Console.WriteLine("prohral jsi");}
    