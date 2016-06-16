namespace Timer
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            TimerDelegate timer = new TimerDelegate(1000, 10, () => Console.WriteLine("Event Triggered"));
            Thread myThread = new Thread(new ThreadStart(timer.Driver));
            myThread.Start();
        }
    }
}
