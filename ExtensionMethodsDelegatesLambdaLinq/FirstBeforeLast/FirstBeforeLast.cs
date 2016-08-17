namespace FirstBeforeLast
{
    using System;
    using System.Linq;

    class FirstBeforeLast
    {
        static void Main(string[] args)
        {
            var arr = new[] {
                    new { First = "Rado", Last = "Genov", Age = 35},
                    new { First = "Alex", Last = "Foster", Age = 20 },
                    new { First = "Bob", Last = "Hogan", Age = 22 }
                };

            var firstBeforeLast = arr.Where(name => name.First.CompareTo(name.Last) < 0);

            //query version
            //var firstBeforeLast = from student in arr
            //                       where (student.First.CompareTo(student.Last) < 0)
            //                       select (student);

            foreach (var item in firstBeforeLast)
            {
                Console.WriteLine(item);
            }
        }
    }
}
