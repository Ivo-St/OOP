namespace FractionCalculator
{
    using System;
    public struct Fraction
    {
        private Int64 denominator;

        public Fraction(Int64 numerator, Int64 denominator)
            :this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public Int64 Numerator { get; set; }

        public Int64 Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denominator + second.Numerator * first.Denominator, first.Denominator * second.Denominator);
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denominator - second.Numerator * first.Denominator, first.Denominator * second.Denominator);
        }

        public override string ToString()
        {
            return String.Format("{0}",(decimal)this.Numerator / this.Denominator);
        }
    }
}
