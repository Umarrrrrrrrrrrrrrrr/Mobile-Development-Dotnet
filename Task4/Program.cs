namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a generic Teacher instance and call methods
            Teacher englishTeacher = new Teacher("Umar Ansar");
            englishTeacher.Teaching();        // Calls the base Teaching method
            Teacher.SalaryInfo();             // Calls static method (cannot be overridden)

            Console.WriteLine();

            // Create a NepaliTeacher instance and call methods
            NepaliTeacher nepaliTeacher = new NepaliTeacher("Home Sir");
            nepaliTeacher.Teaching();         // Calls overridden Teaching method
            Teacher.SalaryInfo();             // Static method from base class

            Console.WriteLine();

            // Create an EnglishTeacher instance and call methods
            EnglishTeacher englishTeacher2 = new EnglishTeacher("Rajesh Karki");
            englishTeacher2.Teaching();       // Calls base Teaching method (not overridden)
            Teacher.SalaryInfo();             // Static method from base class

        }
    }
}