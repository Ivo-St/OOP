namespace PCCatalog
{
    public class Component
    {
        private string name;
        private string details;
        private double price;

        public string Name
        {
            set
            {
                Validator.CheckString(value, "Component Name");
                this.name = value;
            }

            get
            {
                return this.name;
            }
        }

        public string Details
        {
            set
            {
                Validator.CheckNullString(value, "Component Details");
                this.details = value;
            }

            get
            {
                return this.details;
            }
        }

        public double Price
        {
            set
            {
                Validator.CheckDouble(value, "Component Price");
                this.price = value;
            }

            get
            {
                return this.price;
            }
        }

        public Component(string name, double price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + ", price: " + this.Price;
        }
    }
}
