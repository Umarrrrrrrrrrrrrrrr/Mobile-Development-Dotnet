namespace Task2;

// Derived class Motorcycle
public class Motarbike : VehicleExample
{
    public bool HasSidecar { get; set; }    // Unique field

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar: {HasSidecar}");
    }
}