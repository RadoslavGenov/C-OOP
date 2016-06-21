namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { FirstName = "Rado", LastName = "Genov", FacultyNum = 1, Telephone = 0228434, Email = "rado@abv.bg", Marks = new List<short> { 6, 6, 6 }, GroupNum = 2 });
            students.Add(new Student() { FirstName = "Pesho", LastName = "Peshev", FacultyNum = 2, Telephone = 0125434, Email = "pesho@hotmail.bg", Marks = new List<short> { 5, 3, 4 }, GroupNum = 2 });
            students.Add(new Student() { FirstName = "Gosho", LastName = "Geshev", FacultyNum = 3, Telephone = 0226434, Email = "gosho@abv.bg", Marks = new List<short> { 8, 3, 4 }, GroupNum = 15 });

            //using query
            var orderedQuery = from student in students
                               where student.GroupNum == 2
                               orderby student.FirstName ascending
                               select student;

            //using lambda
            students.Sort((name1, name2) => name1.FirstName.CompareTo(name2.FirstName));
            var ordered = students.Where(student => student.GroupNum == 2);

            //Extract students by email:
            string emailPattern = @"abv.bg";
            Regex emailRegex = new Regex(emailPattern, RegexOptions.IgnoreCase);
            var emailsABV = students.Where(email => emailRegex.IsMatch(email.Email)).ToList();

            //extract into anonymous class

            //lambda way:
            var anonymousExcellence = students.Where(student => student.Marks.Contains(6));

            //same thing using LINQ:
            var anoymousExcellenceLINQ = from student in students
                                         where (student.Marks.Contains(6))
                                         select new { studentname = student.FirstName, studentgrade = student.Marks };



            foreach (var student in anoymousExcellenceLINQ)
            {
                Console.Write("{0} Marks: ", student.studentname);
                student.studentgrade.ForEach(grade => Console.Write(grade));
                Console.WriteLine();
            }
        }
    }
}
