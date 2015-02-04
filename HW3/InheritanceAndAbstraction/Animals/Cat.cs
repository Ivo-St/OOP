namespace Animals
{
    using System;
    public class Cat : Animal
    {
        public Cat(string name, int age, Gender gender, string breed=null)
            :base(name,age,gender)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override void ProduceSound()
        {
            Console.WriteLine("Mayyyy");
        }
    }
}
