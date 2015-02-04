namespace Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age, string breed=null)
            : base(name, age, Gender.Female, breed) { }
    }
}
