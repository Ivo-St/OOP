namespace StringDisperser
{
    using System;

    public class StringDisperserMain
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

        }
    }
}
