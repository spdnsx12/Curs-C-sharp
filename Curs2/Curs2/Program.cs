using System;
using System.ComponentModel.Design.Serialization;

namespace Curs2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Exercitiu numere");
            Console.Write("Introduceti primul numar: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar: ");
            b = int.Parse(Console.ReadLine());

            (a, b) = (b, a);
    
            Console.WriteLine("Valoarea primului numar dupa insterschimbare este {0} iar valoarea celui de al doilea lea numar este {1}", a, b);  
        }
    }

}
