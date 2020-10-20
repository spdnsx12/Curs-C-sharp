using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace App3
{
    public class Money
    {
        public decimal Amount{get; set;}
        public string Currency { get; set; }

        public string GetAmountWithCurrency()
        { 
            return Amount + "" + Currency;
        }

        public void MultiplyAmount(int multiply)
        {
            decimal rezultat = multiply * Amount;
        }

    }
}
