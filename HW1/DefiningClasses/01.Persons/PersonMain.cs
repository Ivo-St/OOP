using Persons;
using System;

namespace _01.Persons
{
    class PersonMain
    {
        static void Main()
        {
            Person test = new Person("Test Person", 20, "not@email");
            Console.WriteLine(test);
        }
    }
}
