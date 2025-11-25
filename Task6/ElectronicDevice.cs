namespace Task6
{
    // Abstract class representing a generic electronic device
    public abstract class ElectronicDevice
    {
        private string brand;
        private double price;

        // Gets or sets the brand of the device
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        // Gets or sets the price of the device (must be non-negative)
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new ArgumentException("Price cannot be negative");
            }
        }

        // Constructor to initialize brand and price
        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        // Abstract method to display device information
        public abstract void ShowInfo();
    }
}