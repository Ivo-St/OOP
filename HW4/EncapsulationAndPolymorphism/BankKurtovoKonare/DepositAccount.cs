namespace BankKurtovoKonare
{
    using System;
    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate) { }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return this.Balance * (1 + (decimal)this.InterestRate * months);
        }
    }
}
