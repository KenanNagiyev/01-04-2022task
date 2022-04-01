using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp36.Models
{
    class Group
    {
        public string Groupno { get; set; }
        private int _studentlimit;
        public Group(string groupno, int studentlimit)
        {
            Groupno = groupno;
            StudentLimit = studentlimit;
        }
        public int StudentLimit
        {
            get
            {
                return _studentlimit;
            }
            set
            {
                if (value > 5 && value < 18)
                {
                    _studentlimit = value;
                }
            }
        }
        private Student[] _students = new Student[0];
        public bool CheckGroupno(string groupno)
        {
            if (groupno.Length == 5)
            {
                bool isDigit = false;
                bool isUpper = false;
                foreach (var item in groupno)
                {
                    if (char.IsDigit(item))
                    {
                        isDigit = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        isUpper = true;
                    }
                    if (isDigit && isUpper)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void AddStudent(Student students)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = students;
        }
        public Student GetStudent(int? studentsId)
        {

            foreach (var students in _students)
            {
                if (students.Id == studentsId)
                {
                    return students;
                }
            }
            throw new Exception("Not Found");
        }
        public Student[] GetAllStudents()
        {
            return _students;
        }
        
    }
}
