namespace Animals
{
    using System;
    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender, string description=null)
            :base(name,age,gender)
        {
            this.Description = description;
        }

        public string Description { get; set; }

        public override void ProduceSound()
        {
            Console.WriteLine("Krya-krya");
        }
    }
}
