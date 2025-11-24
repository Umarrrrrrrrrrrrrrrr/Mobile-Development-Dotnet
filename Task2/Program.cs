using System;

namespace Task2
{


    class Program
    {
        static void Main(String[] args)
        {
            // Create an Car object
            Car car = new Car
            {
                Brand = "Toyota",
                Speed = 180.00,
                seats = 5
            }
            ;
            // Create Motorcycle object
            Motarbike moto = new Motarbike
                {
                    Brand = "Toyota",
                    Speed = 195.00,
                    HasSidecar = false
                }
                ;
            // Demonstrate code resuability: start(), stop(), DisplayInfo()
            Console.WriteLine("Car Information:");
            car.Start();
            car.DisplayInfo();
            car.Stop();
            
        }
    }
}
