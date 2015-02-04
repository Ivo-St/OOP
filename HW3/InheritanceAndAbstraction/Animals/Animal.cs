namespace Animals
{
    using System;

    public enum Gender
    {
        Male,
        Female
    };

    public abstract class Animal : ISound
    {
        private string name;
        private int age;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
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
                    throw new ArgumentOutOfRangeException("Age cannot be zero or negative");
                }
                this.age = value;
            }
        }

        public Gender Gender { get; set; }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return this.Name+" "+this.Age+" "+this.Gender;
        }
    }
}
