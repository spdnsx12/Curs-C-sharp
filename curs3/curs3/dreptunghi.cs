using System;

namespace curs3
{
    class dreptunghi
    {
        public string nume { get; set; }
        public double Lungime { get; set; }
        public double latime { get; set; }

        public double CalculeazaAria()
        {
            double Aria = Lungime * latime;
            return Aria;
        }

        public double CalculeazaPerimetru()
        {
            double perimetru = 2 * (Lungime * latime);
            return perimetru;
        }

        public void AfiseazaAria()
        {
            Console.WriteLine("Aria dreptunghiului este: {0}", CalculeazaAria());
        }

        public void AfiseazaPerimetru()
        {
            Console.WriteLine("Perimetrul dreptunghiului este : {0}", CalculeazaPerimetru());
        }
    }



}
