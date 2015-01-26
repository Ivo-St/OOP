using System;
namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        public static int ReadNumber(int start, int end)
        {
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                    throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number that you entered is < than {0} or > then {1}", start, end);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            return number;
        }
        static void Main()
        {
            int start = 1;
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter number {0}: ", i+1);
                a[i] = ReadNumber(start, 100);
                while (a[i] <= start || a[i] >= 100)
                {
                    Console.WriteLine("Please enter another number {0}: ", i+1);
                    a[i] = ReadNumber(start, 100);
                }
                start = a[i];
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
