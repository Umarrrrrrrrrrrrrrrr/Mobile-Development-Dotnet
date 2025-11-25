namespace Task4
{
    // Represents a generic teacher
    public class Teacher
    {
        // Teacher's name
        public string Name { get; set; }

        // Constructor to initialize the teacher's name
        public Teacher(string name)
        {
            Name = name;
        }

        // Teaching method (can be overridden by derived classes)
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Displays salary information (cannot be overridden)
        public static void SalaryInfo()
        {
            Console.WriteLine("Teacher's salary information is confidential");
        }
    }
}