using System;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extra");

            Money myBalance = new Money();
            myBalance.Amount = 20;
            myBalance.Currency = "EUR";

            BankAccount myAccount = new BankAccount();
            myAccount.balance = myBalance;

            myAccount.PrintCurrentBalance();

            myAccount.DepositAmount(10);
            myAccount.PrintCurrentBalance();

            myAccount.WithdrawAmount(100);
            myAccount.PrintCurrentBalance();

            myAccount.WithdrawAmount((decimal)15.5);
            myAccount.PrintCurrentBalance();
        }
    }
}
