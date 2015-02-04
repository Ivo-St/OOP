namespace Animals
{
    using System;

    public class Dog : Animal
    {
        private string breed;

        public Dog(string name, int age, Gender gender, string breed=null)
            :base(name,age,gender)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                if (value=="")
                {
                    throw new ArgumentException("Breed cannot be empty string");
                }
                this.breed = value;
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bark-bark");
        }
    }
}
