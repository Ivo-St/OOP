namespace InterestCalculator
{
    using System;

    class TestCalculator
    {
        static void Main()
        {
            InterestCalculator compount = new InterestCalculator(2500m, 7.2, 15, GetSimpleInterest);
            Console.WriteLine("{0:0.0000}", compount.PaybackValue);

            InterestCalculator simple = new InterestCalculator(500m, 5.6, 10, GetCompoundInterest);
            Console.WriteLine("{0:0.0000}", simple.PaybackValue);
        }

        private static decimal GetCompoundInterest(decimal money, double interest, int years)
        {
            decimal compoundInterest = money * (decimal)Math.Pow(1 + (interest / 12 / 100), years * 12);
            return compoundInterest;
        }

        private static decimal GetSimpleInterest(decimal money, double interest, int years)
        {
            decimal simpleInterest = money * (decimal)(1 + (interest * years / 100));
            return simpleInterest;
        }
    }
}
