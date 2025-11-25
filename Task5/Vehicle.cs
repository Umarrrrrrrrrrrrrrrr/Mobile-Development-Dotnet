namespace Task5
{
    // Abstract class representing a generic vehicle
    public abstract class Vehicle
    {
        // Starts the vehicle's engine 
        public abstract void StartEngine();

        // Stops the vehicle's engine
        public abstract void StopEngine();

        // Displays a generic message about the vehicle
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}