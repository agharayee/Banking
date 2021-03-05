using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Banking.Services
{
    public class AddAccount
    {
        public AddAccount()
        {
            AccountList = new List<Account>();
        }
        public bool OpenAccount(string name, string address, string contactNumber, double balance, string accountNumber)
        {
            // using (var writer = File.AppendText($"Bobs Simple Bank.txt"))
            // {
            // writer.WriteLine( name, address,contactNumber,balance,accountNumber);
            AccountList.Add(new Account
            {

                Name = name,
                Address = address,
                ContactNumber = contactNumber,
                Balance = balance,
                AccountNumber = accountNumber
            });

            // }
            return true;
        }

        public IEnumerable<Account> GetAllAccount()
        {
            return new List<Account>
            {
                new Account {ID = 1, Name = "Agharaye Emmanuel",  Address = "Block 92 flat 6 kubwa abuja",
                                            ContactNumber = "+234876261518", Balance = 200000},
                 new Account {ID = 2, Name = "Agharaye Deborah",  Address = "Block 92 flat 6 kubwa abuja",
                                            ContactNumber = "+234876261518", Balance = 500000}
            };


        }

        public Account GetAccountByName(string name)
        {
            return GetAllAccount().FirstOrDefault(acc => acc.Name == name);
        }

        public Account GetAllAccountOnList(string name)
        {
            return AccountList.Find(acc => acc.Name == name);
        }
        private List<Account> AccountList;

    }
}