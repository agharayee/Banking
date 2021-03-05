using System;

namespace Banking.Services
{
    public class Withdrawal
    {
        //Withdraw funds from balance 
        public double AddWithdrawal(double amount, string name)
        {
            var addAccount = new AddAccount();
            var account = new Account();
            var User = addAccount.GetAccountByName(name);
           // var user = addAccount.GetAllAccountOnList(name);
            if (User == null)
            {
                System.Console.WriteLine("User does not exist");
            }
            else
            {
                //System.Console.WriteLine($"Welcome to simple bank {User.Name}");
               // System.Console.WriteLine("Enter Amount to Withdraw");
                if (amount > User.Balance)
                {
                    Console.WriteLine($"{amount} is greater than your current balance");
                }
                else
                {
                    var newBalance = User.Balance -= amount;
                    System.Console.WriteLine("Please Take your Cash");
                    System.Console.WriteLine($"your new balance is {newBalance}");
                    return newBalance;
                }
            }

            return 0;

        }
    }
}