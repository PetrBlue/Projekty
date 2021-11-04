using System;

namespace PythagorovaVeta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Zadej hodnotu a:");
            Console.ForegroundColor = ConsoleColor.White;
            int a = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Zadej hodnotu b:");
            Console.ForegroundColor = ConsoleColor.White;
            int b = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Napiš co chceš s číslem dělat: \r\n 1) Spočítat odvěsnu \r\n 2) Spočítat příponu");
            int cochces = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            if (cochces == 1)
            {
                a = a * a;
                b = b * b;
                if(a <= b)
                {
                   int vysledek = b - a;
                    Math.Sqrt(vysledek);
                    Console.WriteLine("Výsledek je " + vysledek);
                }
                if (a >= b)
                {
                    int vysledek = a - b;
                    Math.Sqrt(vysledek);
                    Console.WriteLine("Výsledek je " + vysledek);
                }
            }
            if (cochces == 2)
            {
                a = a * a;
                b = b * b;
                if (a <= b)
                {
                    int c = b + a;
                    System.Math.Sqrt(c);
                    Console.WriteLine("Výsledek je " + c
                        
                        );
                }
            }
        }
    }
}
