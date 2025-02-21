namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating student 1
            Student student1 = new Student("Big Chungus", "123456", 20, "Afternoon", "Reality TV Analysis", true);

            //Creating student 2
            Student student2 = new Student("Bingus Bongus", "456987", 18, "Morning", "Advanced Reading", false);

            //Creating student 3
            Student student3 = new Student("John Pork", "987654", 454, "Night", "History of Atlantis", true);

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            //Method to take user input of a new student's details and add it to the list
            void addStudent()
            {
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
                if (paidYesNo.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    paid = true;
                }
                else if (paidYesNo.Equals("No", StringComparison.OrdinalIgnoreCase))
                {
                    paid = false;
                }
                Student student = new Student(name, number, age, classTime, course, paid);
                students.Add(student);
            }

            //Method to display all students in the list
            void displayStudents()
            {
                foreach (var item in students)
                {
                    item.displayDetails();
                }
            }

            //Looping until the user chooses to exit the program
            while (true)
            {
                Console.WriteLine("Enter 1 to add a student, 2 to display all students, or 3 to exit: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    addStudent();
                }
                else if (choice == 2)
                {
                    displayStudents();
                }
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }

        }
    }
}
