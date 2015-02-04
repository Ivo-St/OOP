namespace Shapes
{
    using System;
    public class Triangle : BasicShape
    {
        private double thirdSide;

        public Triangle(double width, double height, double thirdSide)
            : base(width, height)
        {
            CheckForValidTriangle(width, height, thirdSide);
            this.ThirdSide = thirdSide;
        }

        private void CheckForValidTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide >= thirdSide + secondSide || secondSide >= thirdSide + firstSide ||
                thirdSide >= firstSide + secondSide)
            {
                throw new ArithmeticException("Invalid triangle.");
            }
        }

        private double HeronFormula(double a, double b, double c)
        {
            double p = CalculateP(a, b, c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private double CalculateP(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }

        public double ThirdSide
        {
            get
            {
                return this.thirdSide;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Triangle side cannot be negative number");
                }
                this.thirdSide = value;
            }
        }

        public override double CalculateArea()
        {
            return HeronFormula(this.Width, this.Height, this.ThirdSide);
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.Height + this.ThirdSide;
        }
    }
}
