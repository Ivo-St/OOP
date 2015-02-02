namespace School.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private List<Student> students;

        public Discipline(string name, int numberOfLectures, List<Student> students, string details = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.Students = students;
            this.Details = details;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Discipline name cannot be null or empty");
                }
                this.name = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be negative or zero");
                }
                this.numberOfLectures = value;
            }
        }
        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("The course cannot have zero students");
                }
            }
        }
        public string Details { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.Name + this.NumberOfLectures);
            return result.ToString();
        }
    }
}
