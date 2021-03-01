using System.Collections.Generic;

namespace Banking.Services
{
    public class AddAccount
    {
        public AddAccount()
        {
            AccountList = new List<Account>();
        }
        public bool OpenAccount(int id, string name, string address, string contactNumber, double balance) //string accountNumber)
        {
            AccountList.Add(new Account
            {
                Name = name,
                Address = address,
                ContactNumber = contactNumber,
                Balance = balance,
                //Account.AccountNumber = accountNumber
            });
            return true;
        }
        private List<Account> AccountList;

    }
}