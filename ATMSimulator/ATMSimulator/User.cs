using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    class User
    {
        public string Name { get; set; }
        string AccountNumber { get; set; }

        public User(string name, string accountNumber)
        {
            Name = name;
            AccountNumber = accountNumber;
        }
    }
}
