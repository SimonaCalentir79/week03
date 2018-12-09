using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorApp
{
    public class Course
    {
        public string Name { get; set; }

        public string numeProf;
        public Professor Teacher(string numeProf)
        {
            Professor profNou = new Professor(numeProf){ Name = numeProf };
            return profNou;
        }
        public int Year { get; set; }
        public List<Student> Pupil = new List<Student>();

        public void Print()
        {
            Console.WriteLine($"Course {Name} teached by {Teacher(numeProf).Name} for year {Year}");
            Console.WriteLine($"is attended by the following students:");
            foreach (var std in Pupil)
                Console.WriteLine($"   {std.Name}");
        }
    }
}
