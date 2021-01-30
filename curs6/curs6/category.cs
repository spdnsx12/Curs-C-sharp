using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs6
{

    public class category
    {
        public int id { get; set; }
        public string nume { get; set; }
        public string descriere { get; set; }

        public category(int id, string nume, string descriere)
        {
            this.id = id;
            this.nume = nume;
            this.descriere = descriere;
        }

        public category()
        {
                
        }
    }

}
