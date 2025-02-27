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

            StudentManagement studentList = new StudentManagement(students);

            //Looping until the user decides to exit the program
            while (true)
            {
                Console.WriteLine("Enter 1 to add a student, 2 to display all students, or 3 to exit: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    studentList.addStudent();
                }
                else if (choice == 2)
                {
                    studentList.displayStudents();
                }
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again, either choose 1 to add a student, 2 to display all students or 3 to exit.");
                }
            }

        }
    }
}
