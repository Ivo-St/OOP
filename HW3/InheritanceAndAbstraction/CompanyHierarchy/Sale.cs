namespace CompanyHierarchy
{
    using System;
    public class Sale : ISale
    {
        private string productName;
        private decimal price;

        public Sale(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Date = DateTime.Now;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Product name cannot be null or empty");
                }
                this.productName=value;
            }
        }

        public System.DateTime Date { get; private set; }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return this.ProductName + " " + this.Price + " " + this.Date;
        }
    }
}
