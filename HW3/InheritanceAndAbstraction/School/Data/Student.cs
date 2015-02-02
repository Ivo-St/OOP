namespace School.Data
{
    using System;
    using System.Text;
    public class Student : Person
    {
        private string classNumber;

        public Student(string name, string classNumber, string details=null)
            : base(name, details)
        {
            this.ClassNumber = classNumber;
        }

        public string ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Class number cannot be null or empty");
                }
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString()+" "+this.ClassNumber);
            return result.ToString();
        }
    }
}
