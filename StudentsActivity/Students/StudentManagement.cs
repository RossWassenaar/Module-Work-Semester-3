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
            //Accepting user inputted values for the new student
            Console.WriteLine("Enter student name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter student number: ");
            String number = Console.ReadLine();
            Console.WriteLine("Enter student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student class time: ");
            String classTime = Console.ReadLine();
            Console.WriteLine("Enter student course: ");
            String course = Console.ReadLine();
            Console.WriteLine("Has the student paid? (Yes/No): ");
            String paidYesNo = Console.ReadLine();
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
            String studentType = Console.ReadLine();

            //Checking if the user inputted "Yes" or "No" and creating the correct type of student
            if (studentType.Equals("Undergraduate", StringComparison.OrdinalIgnoreCase))
            {
                //asking the user for the list of modules the student is enrolled in
                Console.WriteLine("Enter the number of modules the student is enrolled in:");
                int numModules = int.Parse(Console.ReadLine());
                List<String> modules = new List<string>();
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
                Student student = new Student(name, number, age, classTime, course, paid);
                students.Add(student);
            }
        }

        //Method to display all students in the list
        public void displayStudents()
        {
            foreach (var item in students)
            {
                item.displayDetails(); //uses the displayDetails method either from the Student class or the UndergraduateStudent class, polymorphism in action
            }
        }
    }
}
