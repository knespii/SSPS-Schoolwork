using System;

namespace MyApp
{
    class Papani
    {
        public string Nazev;
        public float Kalorie;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Papani jidlo = new Papani();

            jidlo.Nazev = "susenka";
            jidlo.Kalorie = 600f;

            Console.WriteLine($"Název: {jidlo.Nazev}, Kalorie: {jidlo.Kalorie}");
        }
    }
}