using Persons;
using System;

namespace _01.PersonsMain
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
