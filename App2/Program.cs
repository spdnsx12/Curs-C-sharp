using System;

namespace App2
{
    public enum SpecializareFacultate
    {
        Automatica = 1, Electronica = 2, Comunicatii = 3, Auto = 4,
        Finante = 5, Contabilitate = 6
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase si Obiecte!");
            Student stud1 = new Student();

            stud1.setNume("Ionescu");
            stud1.setPrenume("Ion");
            stud1.setVarsta(30);
            stud1.setCnp("1901220171705");
            stud1.setFacultate("ASE");
            stud1.setSpecializare(SpecializareFacultate.Finante);
            stud1.setMedie(9.57f);

            stud1.PrinteazaInformatiiComplete();

            Student stud2 = new Student();
            stud2.setNume("Popescu");
            stud2.setPrenume("Ion");
            stud2.setVarsta(25);
            stud2.setCnp("1800518171704");
            stud2.setFacultate("Politehnica");
            stud2.setSpecializare(SpecializareFacultate.Automatica);
            stud2.setMedie(8.45f);

            stud2.PrinteazaInformatiiComplete();


        }
    }

}
