namespace Task4
{
    // Represents a Nepali teacher derived from the Teacher base class
    public class NepaliTeacher : Teacher
    {
        // Constructor to initialize the teacher's name
        public NepaliTeacher(string name) : base(name) { }

        // Overrides the Teaching method to specify Nepali teaching
        public override void Teaching()
        {
            Console.WriteLine("Teacher teaches in Nepali");
        }
    }
}