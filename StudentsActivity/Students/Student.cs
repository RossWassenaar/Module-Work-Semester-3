using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        string name;
        string number;
        int age;
        string classTime;
        string course;
        Boolean paid;

        public Student(string name, string number, int age, string classTime, string course, bool paid)
        {
            this.name = name;
            this.number = number;
            this.age = age;
            this.classTime = classTime;
            this.course = course;
            this.paid = paid;
        }

        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public int Age { get => age; set => age = value; }
        public string ClassTime { get => classTime; set => classTime = value; }
        public string Course { get => course; set => course = value; }
        public bool Paid { get => paid; set => paid = value; }

        public void displayDetails()
        {
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
        }
    }
}
