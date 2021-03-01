using System;
using Banking.Services;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            System.Console.WriteLine($"Welcome to Bobs Simple bank, thank you for banking with us");
            System.Console.WriteLine("Press 1 to open new account with us");
            var id = 1;
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
            System.Console.WriteLine($"Thanks you {firstName} for opening an account with us this is your account number {acc} you have {balance}");

            account.OpenAccount(id,firstName, Address,ContactNumber,convertedBalance);
            var listCount = account.AccountList.Count;
            System.Console.WriteLine(listCount);
        }
    }
}
