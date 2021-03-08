using System;
using System.Linq;

namespace Banking.Services
{
    public class AtmGenerator
    {
        // This method generate a 16 digit atm number using luhm algorithms
        public string AtmNumberGenerator(){
            var random = new Random();
            var secondRandom = new Random();
            var secondrand = secondRandom.Next(100000, 9999999);
            var rand = random.Next(100000000, 999999999);
            var AtmNumber = "" + rand + secondrand;
            return AtmNumber;
        }

        public string LuhnAlgorithm(string atmNumber)
        {
           // var CheckedAtmNumber = checkLuhnsAlgorithm(atmNumber);
            
            var correctValue = checkLuhnsAlgorithm(atmNumber)? atmNumber : default;
            return correctValue;
        }

        public bool checkLuhnsAlgorithm(string atmNumber){
            
            int sum = 0;
            bool alternate = false;
            for (int i = atmNumber.Length - 1; i >= 0; i--)
            {
                char[] nx = atmNumber.ToArray();
                int n = int.Parse(nx[i].ToString());

                if (alternate)
                {
                    n *= 2;

                    if (n > 9)
                    {
                        n = (n % 10) + 1;
                    }
                }
                sum += n;
                alternate = !alternate;
            }
            return (sum % 10 == 0);
        }
    }
}