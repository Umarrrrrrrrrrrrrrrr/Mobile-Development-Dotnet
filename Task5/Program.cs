namespace  Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects of Car and Bike using Vehicle_1 reference
            Vehicle myCar = new Car();
            Vehicle myBike = new Bike();

            // Call methods on the Car object
            myCar.Display();        // Calls concrete method from Vehicle_1
            myCar.StartEngine();    // Calls overridden StartEngine method in Car_1
            myCar.StopEngine();     // Calls overridden StopEngine method in Car_1

            Console.WriteLine();    // Separate output for clarity

            // Call methods on the Bike object
            myBike.Display();       // Calls concrete method from Vehicle_1
            myBike.StartEngine();   // Calls overridden StartEngine method in Bike_1
            myBike.StopEngine();    // Calls overridden StopEngine method in Bike_1


        }
    }
}