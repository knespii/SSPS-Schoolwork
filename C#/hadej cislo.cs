Random rnd  = new Random();
int num =  rnd.Next(0,100);

Console.WriteLine("hadej cislo mezi 0-100");
int i;

do
{
    i = Convert.ToInt32(Console.ReadLine());

    if (i < num)
    {
        Console.WriteLine("vetsi");
    }
    else if (i > num)
    {
        Console.WriteLine("mensi");
    }

} while (i != num);

Console.WriteLine("Spravne");
