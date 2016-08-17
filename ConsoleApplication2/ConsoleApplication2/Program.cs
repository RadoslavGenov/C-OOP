using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static int binarySearch(int[] array, int value, int left, int right)
        {
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (array[middle] == value)
                {
                    return middle;
                }
                else if (array[middle] > value)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            var ar = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int x = binarySearch(ar, 0, 0, ar.Length - 1);
        }
    }
}
