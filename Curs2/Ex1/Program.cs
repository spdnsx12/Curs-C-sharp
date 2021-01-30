using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar;
            Console.Write("Introduceti un numar: ");
            numar = int.Parse(Console.ReadLine());

            if (numar % 2 == 0)
            {
                Console.WriteLine("Numarul este par");
            }
            else
            {
                Console.WriteLine("Numarul este impar");
            }
            Console.ReadKey();
        }
    }
}
