namespace Animals
{
    class Tomcat:Cat
    {
        public Tomcat(string name, int age, string breed=null)
            : base(name, age, Gender.Male, breed) { }
    }
}
