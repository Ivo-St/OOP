using System;
using System.Text;
using System.Globalization;
namespace LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manifacturer;
        private string processor;
        private int? ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double? batteryLife;
        private double price;

        private string createString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("model: " + this.Model);
            if (Validator.IsValidString(this.Manifacturer))
                result.AppendLine("manifacturer: " + this.Manifacturer);
            if (Validator.IsValidString(this.Processor))
                result.AppendLine("processor: " + this.Processor);
            if (Validator.IsValidInt(this.RAM))
                result.AppendLine("RAM: " + this.RAM + " GB");
            if (Validator.IsValidString(this.GraphicsCard))
                result.AppendLine("graphics card: " + this.GraphicsCard);
            if (Validator.IsValidString(this.HDD))
                result.AppendLine("hdd: " + this.HDD);
            if (Validator.IsValidString(this.Screen))
                result.AppendLine("screen: " + this.Screen);
            if (Validator.IsValidBattery(this.Battery))
                result.AppendLine("battery: " + this.Battery.ToString());
            if (Validator.IsValidDouble(this.BatteryLife))
                result.AppendLine("battery life: " + this.BatteryLife + "hours");
            result.AppendLine("price: " + this.Price.ToString("0.00") + " BGN");
            return result.ToString();
        }

        public string Model
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Model cannot be null or empty");
                this.model = value;
            }
            get
            {
                return this.model;
            }
        }

        public string Manifacturer
        {
            set
            {
                Validator.checkString(value, "Manifacturer");
                this.manifacturer = value;
            }
            get
            {
                return this.manifacturer;
            }
        }

        public string Processor
        {
            set
            {
                Validator.checkString(value, "Processor");
                this.processor = value;
            }

            get
            {
                return this.processor;
            }
        }

        public int? RAM
        {
            set
            {
                Validator.checkInt(value.GetValueOrDefault(), "RAM");
                this.ram = value;
            }

            get
            {
                return this.ram;
            }
        }

        public string GraphicsCard
        {
            set
            {
                Validator.checkString(value, "GraphicsCard");
                this.graphicsCard = value;
            }

            get
            {
                return this.graphicsCard;
            }
        }

        public string HDD
        {
            set
            {
                Validator.checkString(value, "HDD");
                this.hdd = value;
            }

            get
            {
                return this.hdd;
            }
        }

        public string Screen
        {
            set
            {
                Validator.checkString(value, "Screen");
                this.screen = value;
            }

            get
            {
                return this.screen;
            }
        }

        public Battery Battery
        {
            set
            {
                this.battery = value;
            }

            get
            {
                return this.battery;
            }
        }

        public double? BatteryLife
        {
            set
            {
                Validator.checkDouble(value.GetValueOrDefault(), "BatteryLife");
                this.batteryLife = value;
            }

            get
            {
                return this.batteryLife;
            }
        }

        public double Price
        {
            set
            {
                Validator.checkDouble(value, "Price");
                this.price = value;
            }

            get
            {
                return this.price;
            }
        }

        public Laptop(string model, double price)
        {
            Model = model;
            Price = price;
        }

        public Laptop(string model, double price, string manifacturer = null, string processor = null, int? ram = null, string graphics = null,
                string hdd = null, string screen = null, Battery battery = null, double? batteryLife = null)
                : this(model,price)
        {
            this.Manifacturer = manifacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphics;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
        }

        public override string ToString()
        {
            return createString();
        }
    }
}
