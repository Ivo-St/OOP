using Persons;
using System;

namespace Persons
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
