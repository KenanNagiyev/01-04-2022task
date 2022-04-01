using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp36.Models
{
    class Student
    {
        public int Id { get; }
        public string FullName { get; set; }
        public int Point { get; set; }
        private static int _id;
       
        private Student()
        {
            ++_id;
            Id = _id;
        }
        public Student(string fullname, int point):this()
        {
            FullName = fullname;

            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"fullname:{FullName},Id:{Id}");
        }
    }
}
