using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs6
{
    public class shop
    {
        public List<category> Categories { get; set; }
        public List<product> Products { get; set; }

        public shop()
        {
            Categories = new List<category>();
            Products = new List<product>();
        }
    }
}
