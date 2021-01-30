using System;

namespace whileStm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercitiu While");
            int nr = 3;
            while(nr < 10)
            {
                Console.Write(nr + " " );
                nr+=2;
            }

            int nr2 = 0;
            do
            {
                Console.Write(nr2 + " ");
                nr += 2;
            } while (nr2 < 10);




        }
    }
}
