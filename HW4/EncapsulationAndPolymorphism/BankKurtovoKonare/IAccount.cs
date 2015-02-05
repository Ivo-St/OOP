namespace BankKurtovoKonare
{
    public interface IAccount
    {
        Customer Customer { get; }
        decimal Balance { get; }
        double InterestRate { get; }
        decimal CalculateInterest(int months);
    }
}
