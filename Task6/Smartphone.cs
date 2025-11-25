namespace Task6
{
    // Represents a Smartphone, derived from the ElectronicDevice abstract class
    public class Smartphone : ElectronicDevice
    {
        // Constructor to initialize brand and price
        public Smartphone(string brand, double price) : base(brand, price) { }

        // Enables the smartphone's camera
        public void EnableCamera()
        {
            Console.WriteLine($"{Brand} smartphone camera is enabled");
        }

        // Displays smartphone details
        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone Brand: {Brand}");
            Console.WriteLine($"Price: ${Price}");
        }
    }
}