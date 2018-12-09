using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorApp
{
    public class Student
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int Year { get; set; }

        public string Print()
        {
            return $"   {Name} {Faculty} {Year}";
        }

        //public Student(string name, string faculty, int year)
        //{
        //    this.Name = name;
        //    this.Faculty = faculty;
        //    this.Year = year;
        //}
    }
}
