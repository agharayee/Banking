using System.Collections.Generic;
using System.Linq;

namespace Banking.Services
{
    public class AccountRepository
    {
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

        public Account GetAccountById(int accountId)
        {
            return GetAllAccount().FirstOrDefault(acc => acc.ID == accountId);
        }


    }
}