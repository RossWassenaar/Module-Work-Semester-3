namespace OOPActivity1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating student 1
            Student student1 = new Student("Big Chungus", "123456", 20, "Afternoon", "Reality TV Analysis", true);          

            //Creating student 2
            Student student2 = new Student("Bingus Bongus", "456987", 18, "Morning", "Goonermetrics", false);

            //Creating student 3
            Student student3 = new Student("John Pork", "987654", 454, "Night", "History of Atlantis", true);

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            //Displaying student details
            student1.displayDetails();
            student2.displayDetails();
            student3.displayDetails();

        }
    }
}
