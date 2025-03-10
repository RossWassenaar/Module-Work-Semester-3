using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentManagement
    {
        List<Student> students = new List<Student>();

        public List<Student> Students { get => students; set => students = value; }

        public StudentManagement(List<Student> students)
        {
            this.students = students;
        }

        //Method to take user input of a new student's details and add it to the list
        public void addStudent()
        {
            string name;
            string number;
            int age;
            //Accepting user inputted values for the new student
            Console.WriteLine("Enter student name: ");
            while (true)
            {
                try
                {
                    name = Console.ReadLine();
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You must input a student name");
                }
            }
            
            Console.WriteLine("Enter student number: ");
            while (true)
            {
                try
                {
                    number = Console.ReadLine();
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You must input a student number")
                }
            }
            
            Console.WriteLine("Enter student age: ");
            while (true)
            {
                try
                {
                    age = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please enter a valid age");
                }
            }
            Console.WriteLine("Enter student class time: ");
            string classTime = Console.ReadLine();
            Console.WriteLine("Enter student course: ");
            string course = Console.ReadLine();
            Console.WriteLine("Has the student paid? (Yes/No): ");
            string paidYesNo = Console.ReadLine();
            Boolean paid = true;

            //Checking if the user inputted "Yes" or "No" and setting the paid variable accordingly
            if (paidYesNo.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                paid = true;
            }
            else
            {
                paid = false;
            }

            //Asking the user what type of student is to be added (Undergraduate or Postgraduate)
            Console.WriteLine("Is the student an undergraduate or postgraduate student? (Undergraduate/Postgraduate):");
            string studentType = Console.ReadLine();

            //Checking if the user inputted "Yes" or "No" and creating the correct type of student
            if (studentType.Equals("Undergraduate", StringComparison.OrdinalIgnoreCase))
            {
                //asking the user for the list of modules the student is enrolled in
                Console.WriteLine("Enter the number of modules the student is enrolled in:");
                int numModules = int.Parse(Console.ReadLine());
                List<string> modules = new List<string>();
                for (int i = 0; i < numModules; i++)
                {
                    Console.WriteLine("Enter module " + (i + 1) + ": ");
                    modules.Add(Console.ReadLine());
                }
                UndergraduateStudent student = new UndergraduateStudent(name, number, age, classTime, course, paid, modules);
                students.Add(student);
            }
            else if (studentType.Equals("Postgraduate", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter student research topic:");
                string researchTopic = Console.ReadLine();
                PostgraduateStudent student = new PostgraduateStudent(name, number, age, classTime, course, paid, researchTopic);
                students.Add(student);
            }
            else
            {
                Console.WriteLine("Please enter a valid student type");
            }
        }

        //Method to display all students in the list
        public void displayStudents()
        {
            foreach (var item in students)
            {
                item.DisplayDetails(); //uses the displayDetails method either from the Student class or the UndergraduateStudent class, polymorphism in action
            }
        }
    }
}
