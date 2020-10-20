using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Shape
    {
#pragma warning disable CS0649 // Field 'Shape.nume' is never assigned to, and will always have its default value null
       public string nume;
#pragma warning restore CS0649 // Field 'Shape.nume' is never assigned to, and will always have its default value null

        public double CalculeazaAria()
        {
            return 0;
        }

        public double CalculeazaPerimetrul()
        {
            return 0;
        }

        public void AfiseazaAria()
        {
            Console.WriteLine();
        }

        public void AfiseazaPerimetrul()
        {
            Console.WriteLine();
        }
    }


}
