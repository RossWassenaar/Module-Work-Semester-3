using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    internal class Budget
    {
        public string ExpenseName { get; set; }
        public float Amount { get; set; }
        public string Category { get; set; }

        public Budget(string expenseName, float amount, string category)
        {
            ExpenseName = expenseName;
            Amount = amount;
            Category = category;
        }

        public override string ToString()
        {
            return $"{ExpenseName} - R{Amount} - {Category}";
        }

    }
}
