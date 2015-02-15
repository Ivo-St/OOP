namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private int groupNumber;

        public Student(string firstName, string lastName, int age, int facultyNumber, int group, string phone, string email, IList<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = group;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative or zero");
                }

                this.age = value;
            }
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value.ToString().Length != 6)
                {
                    throw new ArgumentOutOfRangeException("Faculty number must be 5 digits long");
                }

                this.facultyNumber = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Phone number cannot be null or empty");
                }

                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Email cannot be null or empty");
                }

                if (!value.Contains("@"))
                {
                    throw new ArithmeticException("Invalid email address");
                }

                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Group number cannot be negative");
                }

                this.groupNumber = value;
            }
        }

        public IList<int> Marks { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("First name: {0}\nLast name: {1}\nAge: {2}\nFaculty number: {3}\nGroup number: {4}\nEmail: {5}\nPhone: {6}\nMarks: ", this.FirstName,
                this.LastName, this.Age, this.FacultyNumber, this.GroupNumber, this.Email, this.Phone);
            foreach (var mark in this.Marks)
            {
                result.AppendFormat("{0} ", mark);
            }

            return result.ToString();
        }
    }
}
