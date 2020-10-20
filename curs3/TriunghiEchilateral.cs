using System;

namespace curs3
{
    class TriunghiEchilateral
    {
        public string Nume { get; set; }
        public double Latura { get; set; }

        public double CalculeazaArria()
        {
            double aria = (Math.Pow(Latura, 2) * Math.Sqrt(3)) / 4;
            return aria;
        }

        public double CalculeazaPerimetru()
        {
            double perimetru = 3 * Latura;
            return perimetru;
        }

        public void AfiseazaAria()
        {
            Console.WriteLine("Aria triunghiului echilateral este: {0}", CalculeazaArria());
        }

        public void AfiseazaPerimetru()
        {
            Console.WriteLine("Perimetrul triunghiului echilateral este : {0}", CalculeazaPerimetru());
        }
    }


}
