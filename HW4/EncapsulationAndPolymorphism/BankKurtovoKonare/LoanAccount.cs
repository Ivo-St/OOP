namespace BankKurtovoKonare
{
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate) { }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer == Customer.Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }

                return base.CalculateInterest(months - 3);
            }

            if (this.Customer == Customer.Companie)
            {
                if (months <= 2)
                {
                    return 0;
                }

                return base.CalculateInterest(months - 2);
            }

            return -1;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
