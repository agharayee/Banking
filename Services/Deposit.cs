namespace Banking.Services
{
    public class Deposit
    {
        //Add funds to current balance 
        public double AddDeposit(double deposit, string name)
        {
            var addAccount = new AddAccount();
            var account = new Account();
            var User = addAccount.GetAccountByName(name);
            //addAccount.GetAllAccountOnList(name);
            if (User == null)
            {
                System.Console.WriteLine("User does not exist");
            }
            else
            {
                var newBalance = User.Balance += deposit;
                System.Console.WriteLine($"Your new balance is {newBalance}");
                return newBalance;
            }
            return 0;


        }
    }
}