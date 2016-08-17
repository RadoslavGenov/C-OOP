
namespace OrderBy
{
    using System;
    using System.Linq;

    class OrderBy
    {
        static void Main(string[] args)
        {
            var arr = new[] {
                    new { First = "Rado", Last = "Genov", Age = 35},
                    new { First = "Alex", Last = "Foster", Age = 20 },
                    new { First = "Bob", Last = "Hogan", Age = 22 },
                    new { First = "Rick", Last = "Hi", Age = 22 }
                };

            var orderedDescending = arr.OrderByDescending(name => name.First)
                .ThenByDescending(stud => stud.Last);

            //query version
            var orderedQuery = from student in arr
                               where (student.First.CompareTo(student.First) < 0)
                               select student;


            foreach (var item in orderedDescending)
            {
                Console.WriteLine(item);
            }
        }
    }
}
