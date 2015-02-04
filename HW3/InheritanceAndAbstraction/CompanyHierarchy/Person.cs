namespace CompanyHierarchy
{
    using System;
    public abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        protected Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Id cannot be null or empty");
                }
                this.id = value;
            }
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
                    throw new ArgumentNullException("Last name cannot be empty or null");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName+" "+this.LastName+" "+this.Id;
        }
    }
}
