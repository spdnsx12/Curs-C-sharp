using System;

namespace app4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Curs C# - Proiectul 4");
            Console.WriteLine();
            Console.WriteLine("Introduceti lungimea laturii patratului: ");
            float laturaPatrat = float.Parse(Console.ReadLine());
            Console.WriteLine("Perimetrul patratului este: " + (4*laturaPatrat));
            Console.WriteLine("Aria patratului este: " + (2* laturaPatrat));
            Console.WriteLine("Introduceti diametrul cercului: ");
            float diametrulCercului = float.Parse(Console.ReadLine());
            Console.WriteLine("Lungimea cercului este: " + (2 * Math.PI * diametrulCercului));
            Console.WriteLine("Aria cercului este: " + (Math.PI * Math.Pow(diametrulCercului,2)));
            Console.WriteLine("Introduceti raza sferei: ");
            float razaSferei = float.Parse(Console.ReadLine());
            Console.WriteLine("Aria sferei este: " + (4 * Math.PI * Math.Pow(razaSferei,2)));
            Console.WriteLine("Volumul sferei este: " + ((4* Math.PI * Math.Pow(razaSferei,3))/3));

        }
    }
}
