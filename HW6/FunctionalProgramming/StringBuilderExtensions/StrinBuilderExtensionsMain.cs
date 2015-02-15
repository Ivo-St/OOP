namespace StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class StrinBuilderExtensionsMain
    {
        static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.Append("hello");
            Console.WriteLine(test.Substring(1,3));

            Console.WriteLine(test.RemoveText("el"));

            StringBuilder test2 = new StringBuilder();
            test2.AppendAll<string>(new List<string>() { "test1", " test2" });
            Console.WriteLine(test2);
        }
    }
}
