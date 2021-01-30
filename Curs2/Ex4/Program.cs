using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int rezultat = 1;

            Console.Write("Valoarea lui A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Valoarea lui B: ");
            b = int.Parse(Console.ReadLine());

            for(int i= 1; i <= b; i++)
            {
                rezultat = rezultat * a;

            }
            Console.WriteLine(rezultat);
        }
    }
}
