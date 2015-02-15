namespace CustomLINQExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class CustomLINQExtensionsMain
    {
        static void Main()
        {
            int[] test = {1,3,-44,556,99,0};
            IEnumerable<int> test2 = test.WhereNot<int>((x) => x % 2 == 0);

            foreach (var element in test2)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            test2 = test.Repeat(2);

            foreach (var element in test2)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            var test3 = new List<string>() { "test", "afag", "lolipop" };
            var suffixes = new List<string>() { "st", "pop" };

            foreach (var x in test3.WhereEndsWith(suffixes))
            {
                Console.WriteLine(x);
            }
        }
    }
}
