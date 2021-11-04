using System;

namespace Pooole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš číslo :)");
            int velikost = int.Parse(Console.ReadLine());
            int[] jmeno = new int[velikost];
            Console.WriteLine(jmeno);
        }
    }
}
