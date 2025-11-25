namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of ElectronicsStore
            ElectronicsStore store = new ElectronicsStore();

            // Create Laptop and Smartphone objects
            Laptop myLaptop = new Laptop("Dell", 1499.50);
            Smartphone myPhone = new Smartphone("Apple", 999.99);

            // Add devices to the store
            store.AddDevice(myLaptop);
            store.AddDevice(myPhone);

            // Display details of all devices in the store
            // Includes calling child-specific methods like TurnOnBattery and EnableCamera
            store.ShowAllDeviceDetails();

        }
    }
}