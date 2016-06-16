using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy
{
    class DivisibleBy7And3
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 21, 35 };

            var result = array.Where(num => num % 3 == 0 && num % 7 == 0);

            //query version
            /*
            var resultQuery = from num in array
                              where (num % 7 == 0 && num % 3 == 0)
                              select num;
                              */

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
