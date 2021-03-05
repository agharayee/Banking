using System;
using Banking.Services;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            System.Console.WriteLine($"Press 1 to Open Account");
            System.Console.WriteLine($"Press 2 to Withdraw");
            System.Console.WriteLine($"Press 3 to Deposit");
            System.Console.WriteLine($"Press 4 to Check Balance");
            var input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                System.Console.WriteLine($"Welcome to Bobs Simple bank, thank you for banking with us");
                System.Console.WriteLine("Press 1 to open new account with us");
                //var id = 1;
                System.Console.WriteLine("Please enter First name");
                var firstName = Console.ReadLine();
                System.Console.WriteLine("Please enter Address");
                var Address = Console.ReadLine();
                System.Console.WriteLine("Please enter Contact Number ");
                var ContactNumber = Console.ReadLine();
                System.Console.WriteLine("Please enter Balance");
                var balance = Console.ReadLine();
                var convertedBalance = double.Parse(balance);
                //AccountNumberGeneration ac = new AccountNumberGeneration();
                var accountNumber = AccountNumberGeneration.AccoutNumberGenerator();
                var acc = accountNumber;
                System.Console.WriteLine($"Thanks you {firstName} for opening an account with us this is your account number {acc} you have {balance} in your account");

                AddAccount addAccount = new AddAccount();
                addAccount.OpenAccount(firstName, Address, ContactNumber, convertedBalance, acc);
            }

            if(input == 2)
            {
                var withdraw =  new Withdrawal();
                System.Console.WriteLine("please enter your name");
                var user = Console.ReadLine();
                System.Console.WriteLine("Please Enter the amount you want to Withdraw");
                var amount = double.Parse(Console.ReadLine());
                withdraw.AddWithdrawal(amount, user);
            }

            if(input ==3)
            {
                var deposit = new Deposit();
                System.Console.WriteLine("Please Enter your name");
                var name = System.Console.ReadLine();
                System.Console.WriteLine($"Please Enter the amount to be Deposited");
                var amount = double.Parse(Console.ReadLine());
                deposit.AddDeposit(amount, name);
            }

            if(input == 4)
            {
                var balanceCheck = new BalanceCheck();
                Console.WriteLine("Please Enter your Name");
                var name = Console.ReadLine();
                balanceCheck.CheckBalance(name);
            }
        }
    }
}
