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
        private double price;

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

        public double Price
        {
            set
            {
                Validator.CheckDouble(value, "Price");
                this.price = value;
            }

            get
            {
                return this.price;
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

        public Computer(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Computer(string name, double price, Component processor=null, Component graphics=null, Component motherboard=null, Component ram=null, Component hdd=null)
            : this(name, price)
        {
            this.Processor = processor;
            this.GraphicsCard = graphics;
            this.Motherboard = motherboard;
            this.RAM = ram;
            this.HDD = hdd;
        }
        
    }
}
