namespace HumanStudentWorker
{
    using System;
    class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHours)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHours;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary cannot be negative");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours cannot be negative");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal result;
            result = this.WeekSalary / ((decimal)this.WorkHoursPerDay * 7m);
            return result;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + string.Format("{0:N2}",this.MoneyPerHour());
        }
    }
}
