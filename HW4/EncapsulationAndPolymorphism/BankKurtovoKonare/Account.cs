namespace BankKurtovoKonare
{
    using System;
    public abstract class Account : IAccount
    {
        private double interestRate;

        protected Account(Customer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance { get; protected set; }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative number");
                }
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (1 + (decimal)this.InterestRate * months);
        }

        public override string ToString()
        {
            return "Customer type: " + this.Customer + "\n Balance: " + this.Balance + "\n Interest rate: " + this.InterestRate;
        }
    }
}
