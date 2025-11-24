using System;
namespace Task2;
// Base Case
public class VehicleExample
{
    // Base Classs
    public string Brand { get; set; }
    public double Speed { get; set; }
    
    // Constructor
    public VehicleExample(string brand, double speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public VehicleExample()
    {
        
    }
    
    public void Start()
    {
        Console.WriteLine($"{Brand} starting...");
    }
    
    public void Stop()
    {
        Console.WriteLine($"{Brand} stopping...");
    }
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Speed: {Speed} Km/h");
    }
}

