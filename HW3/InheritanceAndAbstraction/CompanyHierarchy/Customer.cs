namespace CompanyHierarchy
{
    using System;
    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(string id, string firstName, string lastName, decimal netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("NetPurchase amout cannot be negative");
                }
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.NetPurchaseAmount;
        }
    }
}
