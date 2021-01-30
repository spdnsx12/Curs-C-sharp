using System;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Curs C# - Proiectul 3");
            short var_a, var_b, var_c;
            var_a = short.Parse(Console.ReadLine());
            var_b = short.Parse(Console.ReadLine());
            var_c = short.Parse(Console.ReadLine());
            Console.WriteLine("Suma celor 3 numere este: " + (var_a + var_b + var_c));
            Console.WriteLine(var_a + " * " + var_b + " = " + (var_a * var_b)); 
            Console.WriteLine("Catul impartirii lui " + var_c + " la " + var_a + " este: " + (var_c / var_a));
            Console.WriteLine("Restul impartirii lui " + var_a + " la " + var_b + " este: " + (var_a % var_b));
            var_a += var_b;
            var_a -= var_c;
            Console.WriteLine("Noua valoarea a lui var_a este: " + var_a);
            bool var_d = (var_a > 0) && (var_b > 0) && (var_c > 0);
            Console.WriteLine("Variabile var_a, var_b, var_c sunt toate pozitive: " + var_d);
            bool var_e = (var_a > 0) || (var_b > 0);
            Console.WriteLine("Cel putin una din variabilele var_a si var_b este pozitiva: " + var_e);
            var_a++;
            var_a *= 5;
            Console.WriteLine("Noua valoare a variabilei var_a este: " + var_a);
        }

    }
}
