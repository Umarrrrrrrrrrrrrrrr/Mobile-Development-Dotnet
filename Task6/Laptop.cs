namespace Task6
{
    // Represents a Laptop, derived from the ElectronicDevice abstract class
    public class Laptop : ElectronicDevice
    {
        // Constructor to initialize brand and price
        public Laptop(string brand, double price) : base(brand, price) { }

        // Turns on the laptop's battery
        public void TurnOnBattery()
        {
            Console.WriteLine($"{Brand} laptop battery is turned on");
        }

        // Displays laptop details
        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop Brand: {Brand}");
            Console.WriteLine($"Price: ${Price}");
        }
    }
}