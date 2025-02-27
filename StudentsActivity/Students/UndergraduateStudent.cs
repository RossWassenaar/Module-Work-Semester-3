using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students 
{
    //Inheritance: UndergraduateStudent class inherits attributes and methods from the Student Class and adds its own property
    class UndergraduateStudent : Student
    {
        List<String> Modules { get; set; } = new List<string>(); //new attribute of the child class
        public UndergraduateStudent(string name, string number, int age, string classTime, string course, bool paid, List<String> modules) 
            : base(name, number, age, classTime, course, paid) //calls the base class constructor and passes the common attributes
        {
            Modules = modules ?? new List<string>(); //Initialize the modules list
        }

        //Polymorrphism: override the displayDetails method declared in Student class to show the list of modules
        public override void displayDetails()
        {
            base.displayDetails(); //calls the original method from Student
            Console.WriteLine("Moddules Enrolled for: " + string.Join(", ", Modules)); //overrides the method to also display the modules
        }
    }
}
