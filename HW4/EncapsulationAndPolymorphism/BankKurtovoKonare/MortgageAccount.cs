namespace BankKurtovoKonare
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate) { }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer == Customer.Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }

                return base.CalculateInterest(months - 6);
            }

            if (this.Customer == Customer.Companie)
            {
                if (months <= 12)
                {
                    return base.CalculateInterest(months)/2;
                }

                return base.CalculateInterest(months - 12) + base.CalculateInterest(12)/2;
            }

            return -1;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
