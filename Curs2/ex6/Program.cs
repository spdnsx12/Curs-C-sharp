using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {

            int n,multfactor = 1;
            Console.Write("Enter a number:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n,multfactor,n*multfactor);
                multfactor++;
            }
        }
    }
}
