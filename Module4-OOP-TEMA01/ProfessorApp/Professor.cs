using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorApp
{
    public class Professor
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }

        public void Print()
        {
            Console.WriteLine($"   {Name} teaches at {Faculty}, specialization {Specialization}");
        }

        public Professor(string name)
        {
            this.Name = name;
        }
    }
}
