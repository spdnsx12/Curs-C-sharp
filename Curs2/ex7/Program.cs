using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar = new Random().Next(0, 10);
            int numar_user,nr_incercari = 1;
            int option;
            Console.Write("Guess the number: ");
            numar_user = int.Parse(Console.ReadLine());


            while (numar_user != numar)
            {
                Console.Write("Numarul nu a fost ghicit.Vreti sa incercati din nou? < 1 = Da / 0 = Nu> :");
               
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("Guess the number: ");
                    numar_user = int.Parse(Console.ReadLine());
                    nr_incercari++;
                }
                else if (option < 0 || option > 1)
                {
                    Console.WriteLine("Valoarea introdusa nu este corecta");
                }
                else
                {
                    break;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("Ati ghicit numarul din {0} incercari",nr_incercari);





        }
    }
}
