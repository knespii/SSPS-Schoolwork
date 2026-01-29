using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("zadej kolik chces zobrazit clenu finiusovy posloupnosti");
        int pocetClenu = int.Parse(Console.ReadLine());

        Finius(pocetClenu);
    }
    static void Finius(int n)
    {
             int a = 0, b = 1, temp;

            Console.WriteLine("finiusova posloupnost : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                temp = a + b;
                a = b; b = temp;
            }
        }
    }


