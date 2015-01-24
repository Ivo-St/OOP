using System.Text;
namespace PCCatalog
{
    class Computer
    {
        private string name;
        private Component processor;
        private Component graphicsCard;
        private Component motherboard;
        private Component ram;
        private Component hdd;

        private double CalculatePrice()
        {
            double result = 0;

            if (Validator.IsValidComponent(this.Processor))
                result += this.Processor.Price;

            if (Validator.IsValidComponent(this.GraphicsCard))
                result += this.GraphicsCard.Price;

            if (Validator.IsValidComponent(this.Motherboard))
                result += this.Motherboard.Price;

            if (Validator.IsValidComponent(this.RAM))
                result += this.RAM.Price;

            if (Validator.IsValidComponent(this.HDD))
                result += this.HDD.Price;

            return result;
        }

        public static Computer[] SortList(Computer[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i].CalculatePrice() < arr[j].CalculatePrice())
                    {
                        Computer tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }

        public string Name
        {
            set
            {
                Validator.CheckString(value, "Name");
                this.name = value;
            }

            get
            {
                return this.name;
            }
        }

        public Component Processor
        {
            set
            {
                this.processor = value;
            }

            get
            {
                return this.processor;
            }
        }

        public Component GraphicsCard
        {
            set
            {
                this.graphicsCard = value;
            }

            get
            {
                return this.graphicsCard;
            }
        }

        public Component Motherboard
        {
            set
            {
                this.motherboard = value;
            }

            get
            {
                return this.motherboard;
            }
        }

        public Component RAM
        {
            set
            {
                this.ram = value;
            }

            get
            {
                return this.ram;
            }
        }

        public Component HDD
        {
            set
            {
                this.hdd = value;
            }

            get
            {
                return this.hdd;
            }
        }

        public Computer(string name)
        {
            this.Name = name;
        }

        public Computer(string name, Component processor=null, Component graphics=null, Component motherboard=null, Component ram=null, Component hdd=null)
            : this(name)
        {
            this.Processor = processor;
            this.GraphicsCard = graphics;
            this.Motherboard = motherboard;
            this.RAM = ram;
            this.HDD = hdd;
        }

        public string PrintPC()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("PC's name: " + this.Name);
            if (Validator.IsValidComponent(this.Processor))
                result.AppendLine("PC's processor: " + this.Processor);
            if (Validator.IsValidComponent(this.GraphicsCard))
                result.AppendLine("PC's graphics card: " + this.GraphicsCard);
            if (Validator.IsValidComponent(this.Motherboard))
                result.AppendLine("PC's motherboard: " + this.Motherboard);
            if (Validator.IsValidComponent(this.RAM))
                result.AppendLine("PC's ram: " + this.RAM);
            if (Validator.IsValidComponent(this.HDD))
                result.AppendLine("PC's hdd: " + this.HDD);
            result.AppendLine("Components total price: " + CalculatePrice().ToString());
            return result.ToString();
        }
        
    }
}
