using System;

namespace app5
{
    class Program
    {
        static void Main(string[] args)
        {
            int zeciDeMii, Mii, sute, zeci, unitati, numarSalvat;
            Console.WriteLine("C# - Proiect 5");
            Console.WriteLine();
            Console.WriteLine("Introduceti un numar format din 5 cifre");
            int numar = int.Parse(Console.ReadLine());

            while (numar < 10000 || numar > 99999)
            {              
                Console.WriteLine("Introduceti un numar format din 5 cifre");
                numar = int.Parse(Console.ReadLine());
            }

            numarSalvat = numar;
            zeciDeMii = numar / 10000;
            numar %= 10000;
            Mii = numar / 1000;
            numar %= 1000;
            sute = numar / 100;
            numar %= 100;
            zeci = numar / 10;
            numar %= 10;
            unitati = numar / 1;
            Console.WriteLine("Descompunerea numarului: " + numarSalvat + " este : " + zeciDeMii + " * 10000 + " + Mii + " * 1000 + " + sute + " * 100 + " + zeci + " * 10 + " + unitati + " * 1");
            Console.ReadLine();
           
        }
    }
}
