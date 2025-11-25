namespace Task5
{
    public class Bike : Vehicle
    {
        // Starts the bike's engine
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started");
        }

        // Stops the bike's engine
        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped");
        }
    }
}