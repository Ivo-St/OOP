using System;
namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if(number<0)
                    throw new ArgumentOutOfRangeException();
                else
                    Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid Number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
