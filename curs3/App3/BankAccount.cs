using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public class BankAccount
    {
        public Money balance;

        public bool HasPositiveBalance()
        {
            return balance.Amount >= 0;
        }

        public bool HasEnoughAmount(decimal amount)
        {
            return balance.Amount >= amount;
        }

        public void DepositAmount(decimal suma)
        {
            balance.Amount = balance.Amount + suma;
        }

        public void WithdrawAmount(decimal amount)
        {
            bool canWidraw = HasEnoughAmount(amount);
            if (canWidraw == true)
            {
                balance.Amount = balance.Amount - amount;
            }
            else
            {
                Console.WriteLine("Contul nu dispune de: {0} {1}",amount,balance.Currency);
            }
           
        }

        public void PrintCurrentBalance()
        {
            Console.WriteLine("In acest moment in cont aveti:{0}", balance.GetAmountWithCurrency());
        }
    }
}
