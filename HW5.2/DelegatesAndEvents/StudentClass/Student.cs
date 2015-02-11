namespace StudentClass
{
    using System;

    public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs eventArgs);

    public class Student
    {
        private int age;
        private string name;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
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

                this.OnPropertyChanged(new PropertyChangedEventArgs("Name", this.Name, value));
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
                if (value < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Age cannot be negative");
                }

                this.OnPropertyChanged(new PropertyChangedEventArgs("Age", this.Age.ToString(), value.ToString()));
                this.age = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, args);
            }
        }
    }
}
