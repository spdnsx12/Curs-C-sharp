using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,rezultat;
            rezultat = 0;
            Console.Write("Enter a number:");
            n= int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                rezultat += i;
                
            }
            Console.WriteLine("Media primelor {0} numere este {1} :", n, rezultat/n);

        }
    }
}
