namespace IEnumerableExtensions
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3, 4, 5.5 };
            double sum = arr.Sum();
            double product = arr.Product();
            double min = arr.Min();
            double max = arr.Max();
            double average = arr.Average();
            Console.WriteLine("Sum: {0} ", sum);
            Console.WriteLine("Product: {0} ", product);
            Console.WriteLine("Min: {0} ", min);
            Console.WriteLine("Max: {0} ", max);
            Console.WriteLine("Average: {0} ", average);
        }
    }
}
