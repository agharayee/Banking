using System;
using System.Collections.Generic;

namespace Banking.Services
{
    public class Account
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
       // public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public double Balance { get; set; }
        //public int AccountNumber { get; set; }         
        public string AccountNumber;

        public string AtmNumber {get; set;}
   
   }

}