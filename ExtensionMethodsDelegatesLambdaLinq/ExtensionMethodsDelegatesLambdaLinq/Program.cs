namespace Extensions
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder("Hi this is my first extension method!");
            Console.WriteLine(test.SubString(0, test.Length).ToString());
        }
    }
}
