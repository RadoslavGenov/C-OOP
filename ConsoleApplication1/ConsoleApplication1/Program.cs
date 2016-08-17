namespace ConsoleApplication1
{
    using System;

    class Program
    {
        public static void fixx(int N)
        {
            for (int i = 0; i < 30; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("fix");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("bux");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("fix");
                }
                else
                {
                    Console.Write(i);
                }
            }
        }
        static void Main(string[] args)
        {
            fixx(30);
        }
    }
}
