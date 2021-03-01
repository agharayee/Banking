using System;
using System.Collections.Generic;

namespace Banking.Services
{
    public class Account
    {
        public Account()
        {
            AccountList = new List<Account>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
       // public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public double Balance { get; set; }
        //public int AccountNumber { get; set; }         
        public static string AccountNumber;
   
    public bool OpenAccount(int id, string name, string address, string contactNumber, double balance)
    {
        AccountList.Add(new Account{ Name = name, Address = address, ContactNumber = contactNumber, Balance = balance

        });
        return true;
    }
        public List<Account> AccountList;
    }

}