using System;

namespace curs3
{
    class cerc
    {
        public string nume { get; set; }
        public double raza { get; set; }

        public double CalculeazaAria()
        {
            double aria = Math.PI * Math.Pow(raza, 2);
            return aria;
        }

        public double CalculeazaPerimetru()
        {
            double perimetru = 2 * Math.PI * raza;
            return perimetru;
        }

        public void AfiseazaAria()
        {
            Console.WriteLine("Aria cercului este: {0}", CalculeazaAria());
        }

        public void AfiseazaPerimetru()
        {
            Console.WriteLine("Perimetrul cercului este: {0} ", CalculeazaPerimetru());
        }
    }
}
