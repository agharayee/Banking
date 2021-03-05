namespace Banking.Services
{
    public class BalanceCheck
    {
        public double CheckBalance(string name)
        {
            var addAccount = new AddAccount();
            var acc = new Account();
            var User = addAccount.GetAccountByName(name);
           // addAccount.GetAllAccountOnList(name);
           if(User == null)
           {
               System.Console.WriteLine("User is invalid");
           }
           else{
                var balance =  User.Balance;
                System.Console.WriteLine($"Your Balance is {balance}");
                return balance;
           }
            return 0;
        }
    }
}