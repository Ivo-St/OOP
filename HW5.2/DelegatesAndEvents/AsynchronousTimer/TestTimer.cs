namespace AsynchronousTimer
{
    using System;
    using System.Threading;
    class TestTimer
    {
        static void Main()
        {
            AsynchronousTimer test = new AsynchronousTimer(PrintRunning, 5, 2000);
            test.Execute();
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Main thread");
                Thread.Sleep(2000);
                
            }
        }

        static void PrintRunning()
        {
            System.Console.WriteLine("I am running");
        }
    }
}
