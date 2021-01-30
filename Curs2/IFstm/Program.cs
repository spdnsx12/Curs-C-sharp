using System;

namespace IFstm
{
    class Program
    {
        static void Main(string[] args)
        {
            int varsta_Ana, varsta_Maria;
            Console.Write("Varsta Anei este: ");
            varsta_Ana = int.Parse(Console.ReadLine());
            Console.Write("Varsta Mariei este: ");
            varsta_Maria = int.Parse(Console.ReadLine());

            if (varsta_Ana >= 18 && varsta_Maria >= 18)
            {
                Console.WriteLine("Ana si Maria sunt majore");
            }
            else if (varsta_Ana >= 18 || varsta_Maria >= 18)
            {
                Console.WriteLine("Cel putin una din fete este majora");

            }
            else
            {
                Console.WriteLine("Ambele fete sunt minore");
            }

        }
    }
}
