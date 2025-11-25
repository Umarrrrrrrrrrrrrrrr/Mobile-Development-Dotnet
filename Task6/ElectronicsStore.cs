namespace Task6
{
    // Represents a store that manages electronic devices
    public class ElectronicsStore
    {
        // List to store all devices in the store
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        // Adds a device to the store
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to the store.");
        }

        // Removes a device from the store
        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Remove(device))
            {
                Console.WriteLine($"{device.Brand} removed from the store.");
            }
            else
            {
                Console.WriteLine($"{device.Brand} not found in the store.");
            }
        }

        // Displays information for all devices in the store
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n--- All Devices in Store ---");
            foreach (var device in devices)
            {
                device.ShowInfo();

                // Perform child-specific actions using type checking
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone phone)
                {
                    phone.EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}