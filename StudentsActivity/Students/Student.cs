using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    abstract class Student
    {
        //Student attributes
        string name;
        string number;
        int age;
        string classTime;
        string course;
        Boolean paid;

        //encapsulation
        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public int Age { get => age; set => age = value; }
        public string ClassTime { get => classTime; set => classTime = value; }
        public string Course { get => course; set => course = value; }
        public bool Paid { get => paid; set => paid = value; }

        //Student constructor
        public Student(string name, string number, int age, string classTime, string course, bool paid)
        {
            this.name = name;
            this.number = number;
            this.age = age;
            this.classTime = classTime;
            this.course = course;
            this.paid = paid;
        }

        //Abstract method for a template to display an individual student's details
        public abstract void DisplayDetails();
    }


}
