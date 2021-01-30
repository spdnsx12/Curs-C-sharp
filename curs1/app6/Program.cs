using System;

namespace app6
{
    class Program
    {

        static void Main(string[] args)
        
        {
            Console.WriteLine("C# - Proiect 6");
            int var_a = int.Parse(Console.ReadLine());
            int var_b = int.Parse(Console.ReadLine());

            (var_a, var_b) = (var_b, var_a);
            Console.WriteLine("Valoare lui a dupa interschimbare este : " + var_a  + " iar valoarea lui b este : " + var_b);
            Console.ReadKey();

        }
    }
}




