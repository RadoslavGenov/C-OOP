namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Collections;

    public class Student : IComparable<Student>, IEnumerable<Student>
    {
        private string firstName;
        private string lastName;
        private int facultyNum;
        private int telephone;
        private string email;
        private List<short> marks = new List<short>();
        private int groupNum;

        public Student()
        {
            this.firstName = null;
            this.lastName = null;
            this.facultyNum = 0;
            this.telephone = 0;
            this.email = null;
            this.marks = new List<short>();
            this.groupNum = 0;
        }

        public Student(string _firstName, string _lastName, int _facultyNum, int _telephone,
            string _email, List<short> _marks, int _groupNum)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.facultyNum = _facultyNum;
            this.telephone = _telephone;
            this.email = _email;
            this.marks = new List<short>(_marks);
            this.groupNum = _groupNum;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FacultyNum { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public List<short> Marks { get; set; }
        public int GroupNum { get; set; }

        public int CompareTo(Student other)
        {
            throw new NotImplementedException();
        }

        IEnumerator<Student> IEnumerable<Student>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
