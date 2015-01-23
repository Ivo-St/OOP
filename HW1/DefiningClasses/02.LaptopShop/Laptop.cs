using System;
using System.Text;
namespace LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manifacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double batteryLife;
        private double price;

        private string createString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("model: " + Model);
            if (Validator.IsValidString(Manifacturer))
                result.AppendLine("manifacturer: " + Manifacturer);
            if (Validator.IsValidString(Processor))
                result.AppendLine("processor: " + Processor);
            if (Validator.IsValidInt(RAM))
                result.AppendLine("RAM: " + RAM + " GB");
            if (Validator.IsValidString(GraphicsCard))
                result.AppendLine("graphics card: " + GraphicsCard);
            if (Validator.IsValidString(HDD))
                result.AppendLine("hdd: " + HDD);
            if (Validator.IsValidString(Screen))
                result.AppendLine("screen: " + Screen);
            if (Validator.IsValidBattery(Battery))
                result.AppendLine("battery: " + Battery.ToString());
            if (Validator.IsValidDouble(BatteryLife))
                result.AppendLine("battery life: " + BatteryLife);
            result.AppendLine("price: " + Price + "BGN");
            return result.ToString();
        }

        public string Model
        {
            set
            {
                Validator.checkString(value, "Model");
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
                //Validator.checkString(value, "Manifacturer");
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

        public int RAM
        {
            set
            {
                Validator.checkInt(value, "RAM");
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

        public double BatteryLife
        {
            set
            {
                Validator.checkDouble(value, "BatteryLife");
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

        public Laptop(string model, double price, string manifacturer = null, string processor = null, int ram = 0, string graphics = null,
                string hdd = null, string screen = null, Battery battery = null, double batteryLife = 0)
                : this(model,price)
        {
            Manifacturer = manifacturer;
            Processor = processor;
            RAM = ram;
            GraphicsCard = graphics;
            HDD = hdd;
            Screen = screen;
            Battery = battery;
            BatteryLife = batteryLife;
        }

        public override string ToString()
        {
            return createString();
        }
    }
}
