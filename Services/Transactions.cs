using System;

namespace Banking.Services
{
    public class Transactions
    {
        public void Display(){
            System.Console.WriteLine($"Press 1 to Open Account");
            System.Console.WriteLine($"Press 2 to Withdraw");
            System.Console.WriteLine($"Press 3 to Deposit");
            System.Console.WriteLine($"Press 4 to Check Balance");
            Console.WriteLine($"Press 5 to Manage Your Account");

        }
        public void OpenBankAccount(int input)
        {
            if (input == 1)
            {
                System.Console.WriteLine($"Welcome to Bobs Simple bank, thank you for banking with us");
                //System.Console.WriteLine("Press 1 to open new account with us");
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

        }

        public void Withdraw(int input)
        {
            if (input == 2)
            {
                var withdraw = new Withdrawal();
                System.Console.WriteLine("please enter your name");
                var user = Console.ReadLine();
                System.Console.WriteLine("Please Enter the amount you want to Withdraw");
                var amount = double.Parse(Console.ReadLine());
                withdraw.AddWithdrawal(amount, user);
            }

        }
        public void Deposit(int input)
        {
            if (input == 3)
            {
                var deposit = new Deposit();
                System.Console.WriteLine("Please Enter your name");
                var name = System.Console.ReadLine();
                System.Console.WriteLine($"Please Enter the amount to be Deposited");
                var amount = double.Parse(Console.ReadLine());
                deposit.AddDeposit(amount, name);
            }

        }
        public void CheckBalance(int input)
        {
            if (input == 4)
            {
                var balanceCheck = new BalanceCheck();
                Console.WriteLine("Please Enter your Name");
                var name = Console.ReadLine();
                balanceCheck.CheckBalance(name);
            }
        }

        public void ManageAccount(int input){
             if (input == 5)
            {

                Console.WriteLine("Press 1 to Request for an ATM");
                var selected = int.Parse(Console.ReadLine());
                if (selected == 1)
                {                   
                    var atmGenerator = new AtmGenerator();
                        
                        while(true)
                        {
                            //var atm = atmGenerator.AtmNumberGenerator();
                            var atmchecked = atmGenerator.AtmNumberGenerator();
                            var luthCheckedAtm = atmGenerator.checkLuhnsAlgorithm(atmchecked);
                            var verifyAtmNo = atmGenerator.LuhnAlgorithm(atmchecked);
                            if(luthCheckedAtm == true){
                                Console.WriteLine($"This is your Atm Number {atmchecked}");
                                Account acc = new Account();
                                acc.AtmNumber = atmchecked;
                                break;
                            } 
                            
                        } 

                }
            }
        }
    }
}