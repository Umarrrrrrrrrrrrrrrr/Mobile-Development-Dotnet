namespace Task2;

public class Car : VehicleExample
{
    public int seats { get; set; } // unique field

    public override void DisplayInfo()
    {
        // Call base DisplayInfo and add unique field
        base.DisplayInfo();
        Console.WriteLine($"Car seats: {seats}");
    }
}