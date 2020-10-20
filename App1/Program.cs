using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proprietati");

            TriunghiEchilateral te1 = new TriunghiEchilateral();
            te1.Nume = "Triunghi echilateral 1";
            te1.Latura = 5.5;

            TriunghiEchilateral te2 = new TriunghiEchilateral();
            te2.Nume = "Triunghi echilateral 2";
            te2.Latura = 20;

            TriunghiDreptunghic td1 = new TriunghiDreptunghic();
            td1.nume = "Triunghi dreptunghic 1";
            td1.Cateta1 = 10;
            td1.Cateta2 = 5;
            td1.Ipotenuza = 5;

            cerc c1 = new cerc();
            c1.nume = "Cerc 1";
            c1.raza = 7.8;

            dreptunghi dr1 = new dreptunghi();
            dr1.nume = "dreptunghi 1";
            dr1.Lungime = 10;
            dr1.latime = 2;

            dreptunghi dr2 = new dreptunghi();
            dr2.nume = "dreptunghi 2";
            dr2.Lungime = 5;
            dr2.latime = 2;

            te1.AfiseazaAria();
            te1.AfiseazaPerimetru();

            te2.AfiseazaAria();
            te2.AfiseazaPerimetru();

            td1.AfiseazaAria();
            td1.AfiseazaPerimetru();

            c1.AfiseazaAria();
            c1.AfiseazaPerimetru();

            dr1.AfiseazaAria();
            dr1.AfiseazaPerimetru();

            dr2.AfiseazaAria();
            dr2.AfiseazaPerimetru();

        }
    }
}
