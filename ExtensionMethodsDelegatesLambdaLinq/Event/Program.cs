namespace Event
{
    using System;

    class Program
    {
        public static void Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Tick-Tock");
        }

        static void Main(string[] args)
        {
            Event test = new Event(500, 200);
            test.myEvent += Tick;
            test.Drive();
        }
    }
}
