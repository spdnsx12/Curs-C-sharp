using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Curs C# - Proiectul 2");
            int var_a;
            var_a = -5;
            Console.WriteLine("Valoarea variabilei var_a este : " + var_a);
            bool var_b = true;
            var_b = var_a > 0;
            Console.WriteLine("var_a este mai mare ca 0: " + var_b);
            var_a += 20;
            var_a /= 6;
            Console.WriteLine("Noua valoare a variabilei var_a este: " + var_a);
            float var_c = 1.25F;
            var_c *= var_a;
            Console.WriteLine("Variabila var_c are valoarea: " + var_c);
            //short var_d = 20000; //short contine valori pana la 36.767
            //uint var_d = 10; //contine doar valori mai mari ca 0
            long var_e = 10, var_f, var_g = 11;
            bool var_h = false; char var_i = 'B';
        }
    }
}
