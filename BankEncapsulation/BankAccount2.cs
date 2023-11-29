using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{

    public class BankAccount2
    {
        private double  _balance = 0;

        public void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine($"Stimulating a deposit of {amount} to your account!");

        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
