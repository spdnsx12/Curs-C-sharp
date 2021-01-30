using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    class Student
    {
        string nume, prenume, cnp, facultate;
        short varsta;
        float medie;
        SpecializareFacultate specializare = new SpecializareFacultate();

        public string getNume()
        {
            return nume;
        }

        public void setNume(string nume)
        {
            this.nume = nume;
        }

        public string getPrenume()
        {
            return prenume;
        }

        public void setPrenume(string prenume)
        {
            this.prenume = prenume;
        }

        public short getVarsta()
        {
            return varsta;
        }

        public void setVarsta(short varsta)
        {
            this.varsta = varsta;
        }

        public string getCnp()
        {
            return cnp;
        }

        public void setCnp(string cnp)
        {
            this.cnp = cnp;
        }

        public string getFacultate()
        {
            return facultate;
        }

        public void setFacultate(string facultate)
        {
            this.facultate = facultate;
        }

        public SpecializareFacultate getSpecializare()
        {       
            return specializare;
        }

        public void setSpecializare(SpecializareFacultate specializare)
        {
            this.specializare = specializare;
        }

        public float getMedie()
        {
            return medie;
        }

        public void setMedie(float medie)
        {
            this.medie = medie;
        }

        public void PrinteazaInformatiiComplete()
        {
            Console.WriteLine("Studentul {0} {1}, cnp {2} cu varsta de {3} ani este student al facultatii {4}, specializarea {5} avand media {6}", getNume(), getPrenume(), getCnp(), getVarsta(), getFacultate(), getSpecializare(), getMedie());
        }
    }
}
