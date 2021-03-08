using System;
using Banking.Services;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            var transcation = new Transactions();
            transcation.Display();
            var input = int.Parse(Console.ReadLine());
            
            //Opening Account Process
            transcation.OpenBankAccount(input);
            
            //Withdraw funds process
            transcation.Withdraw(input);

            //Check balance process 
            transcation.CheckBalance(input);

           //Manage your account: Request AtmNumber 
           transcation.ManageAccount(input);
        }
    }
}

