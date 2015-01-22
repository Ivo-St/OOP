using System;

namespace Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Name cannot be empty or null");
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age must be between 1 and 100");
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value == null || value.Contains("@"))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email");
                }
            }
        }

        public Person(string n, int a, string e = null)
        {
            Name = n;
            Age = a;
            Email = e;
        }

        public override string ToString()
        {
            if (Email != null)
                return "I am " + Name + " and I am " + Age + " years old. My email is " + Email;
            return "I am " + Name + " and I am " + Age + " years old";
        }
    }
}