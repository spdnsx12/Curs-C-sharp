using System;

namespace ExercitiuPseudo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,z; 
            
            Console.Write("Introduceti valoarea lui Z: ");
            z = int.Parse(Console.ReadLine());

            Console.Write("Introduceti valoarea lui X: ");
            x = int.Parse(Console.ReadLine());
            while (x>0)
            {
                Console.Write("Introduceti valoarea lui Y: ");
                y = int.Parse(Console.ReadLine());
                if (z < y-x)
                {
                    Console.WriteLine("Afisam X % 10 : " + x % 10);
                }
                else
                {
                    Console.WriteLine("Afisam Y % 10 : " + y % 10);
                }
                x = y;
            }
        }
    }
}
