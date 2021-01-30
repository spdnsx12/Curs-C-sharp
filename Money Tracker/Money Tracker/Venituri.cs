using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Tracker
{
    public class Venituri
    {
        public int ID { get; set; }
        public string Descriere { get; set; }
        public decimal Suma { get; set; }
        public string TipVenit { get; set; }
        public string DataVenit { get; set; }
    }
}
