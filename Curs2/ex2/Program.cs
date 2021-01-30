using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Valoarea lui a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Valoarea lui b: ");
            b = int.Parse(Console.ReadLine());
            if (b > 0)
            {
                Console.WriteLine("Catul impartirii lui a la b este {0} iar restul este {1}", a / b, a % b);
            }
            else
            {
                Console.WriteLine("Impartirea nu se poate realiza pentru ca b este 0");
            }

        }
    }
}
