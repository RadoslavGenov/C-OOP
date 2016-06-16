using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRange
{
    class AgeRange
    {
        static void Main(string[] args)
        {
            var arr = new[] {
                new { First = "Rado", Last = "Genov", Age = 35},
                new { First = "Alex", Last = "Foster", Age = 20 },
                new { First = "Bob", Last = "Hogan", Age = 22 }
            };

            var ageRange = arr.Where(student => student.Age <= 24 && student.Age >= 18);

            //query version
            //var ageRange = from student in arr
            //               where (student.Age <= 24 && student.Age >= 18)
            //               select student;

            foreach (var item in ageRange)
            {
                Console.WriteLine(item);
            }
        }
    }
}
