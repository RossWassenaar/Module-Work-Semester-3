using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    abstract class Order
    {
        public int OrderID { get; set; }
        public double Amount { get; set; }
        public abstract void ProcessPayment(); //abstract method to implemented in every child class derived from this parent class
        public virtual void PrintReceipt()
        {
            Console.WriteLine($"Order {OrderID}, Amount Paid: {Amount}");
        }
    }

    class OnlineOrder : Order
    {
        public override void ProcessPayment() //compulsory to implement this method because it is abstract in parent class
        {
            Console.WriteLine($"Processing Online Payment for {OrderID}...");
        }
        public override void PrintReceipt() //using polymorphism to override the method body with a message of your choice aswell
        {
            Console.WriteLine($"Printing receipt for online payment for Order{OrderID}");
            base.PrintReceipt();
        }
    }

    class InPersonOrder : Order
    {
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing Cash Payment for {OrderID}..."); //compulsory to implement this method because it is abstract in parent class
        }
        public override void PrintReceipt()
        {
            Console.WriteLine($"Printing receipt for in-person payment for Order{OrderID}");
            base.PrintReceipt();
        }
    }
}
