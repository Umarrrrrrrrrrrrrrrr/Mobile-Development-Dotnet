namespace Task5
{
    public class Car : Vehicle
    {
        // Starts the car's engine
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        // Stops the car's engine
        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}