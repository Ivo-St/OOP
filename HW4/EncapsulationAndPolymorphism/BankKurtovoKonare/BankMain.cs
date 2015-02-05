namespace BankKurtovoKonare
{
    using System;
    public class BankMain
    {
        static void Main()
        {
            DepositAccount depositAccount = new DepositAccount(Customer.Individual, 1000m, 1);
            Console.WriteLine(depositAccount);
            depositAccount.DepositMoney(100m);
            Console.WriteLine(depositAccount);
            Console.WriteLine(depositAccount.CalculateInterest(12));
        }
    }
}
