using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    class BankAccount
    {
        //class attribute
        public double Balance { get; private set; }

        //constructor
        public BankAccount(double balance)
        {
            Balance = balance;
        }

        //deposit method
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        //withdraw method with validation (prevents overdraft)
        public bool Withdraw(double amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                return true; //transaction successful
            }
            else
            {
                return false; //transaction failed if funds are insufficient
            }
        }
    }
}
