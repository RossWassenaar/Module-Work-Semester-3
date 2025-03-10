using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class PostgraduateStudent : Student
    {
        string ResearchTopic { get; set; }
        public PostgraduateStudent(string name, string number, int age, string classTime, string course, bool paid, string researchTopic)
            : base(name, number, age, classTime, course, paid)
        {
            ResearchTopic = researchTopic;
        }

        public override void DisplayDetails()
        {
            //base.displayDetails(); //calls the original method from Student
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Morning or afternoon classes: {ClassTime}");
            Console.WriteLine($"Course: {Course}");
            if (Paid == true)
            {
                Console.WriteLine("Paid: Yes");
            }
            else
            {
                Console.WriteLine("Paid: No");
            }
            Console.WriteLine();
            Console.WriteLine($"Research Topic: {ResearchTopic}"); //overrides the method to also display the reasearch topic
        }
    }
}
