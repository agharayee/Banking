using System;

namespace Banking.Services
{
    public class AccountNumberGeneration
    {
        public static string AccoutNumberGenerator()
        {
            var rand = new Random();
            var random = rand.Next(100000000, 999999999);
            var accountNumber  = "0" + random;
            return accountNumber; 
        }
    }
}