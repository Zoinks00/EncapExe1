using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
   public  class BankAccount
    {
        
        private double _balance = 0;
               
      public void Deposit(double value)
        {
            Console.WriteLine($"You have made a deposit of {value,0:c} to your account.");
            _balance = value;
        }

        public double GetBalance()
        {
            return _balance;
        }
      
    }
}
