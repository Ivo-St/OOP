namespace GenericList
{
    using System;
    class TestList
    {
        static void Main()
        {
            var version = typeof(GenericList<>).GetCustomAttributes(typeof(VersionAttribute),true);
            Console.WriteLine("The GenericList<T> version is: {0}\n",version);

            GenericList<int> test = new GenericList<int>(2);
            test.AddElement(1);
            test.AddElement(2);
            test.AddElement(4);
            test.InsertElementAt(2, 3);
            Console.WriteLine(test);
        }
    }
}
