namespace School.Data
{
    using System;
    public abstract class Person
    {
        private string name;

        public Person(string name, string details = null)
        {
            this.Name = name;
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
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }
        public string Details { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
