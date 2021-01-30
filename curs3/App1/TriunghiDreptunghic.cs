using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class TriunghiDreptunghic
    {
        public  string nume { get; set; }
        public double Cateta1 { get; set; }
        public double Cateta2 { get; set; }
        public double Ipotenuza { get; set; }

        public double CalculeazaAria()
        {
            double aria = (Cateta1 * Cateta2) / 2;
            return aria;
        }

        public double CalculeazaPerimetrul()
        {
            double perimetru = Cateta1 * Cateta2 * Ipotenuza;
            return perimetru;
        }

        public void AfiseazaAria()
        {
            Console.WriteLine("Aria triunghiului dreptunghic este: {0} ",CalculeazaAria());
        }

        public void AfiseazaPerimetru()
        {
            Console.WriteLine("Perimetrul triunghiului dreptunghic este: {0}", CalculeazaPerimetrul());
        }


    }
}
