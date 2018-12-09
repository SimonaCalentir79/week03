using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorApp
{
    class Program
    {
        static void Main()
        {
            Professor prof1 = new Professor("Marin Fotache") { Faculty = "F.E.A.A.", Specialization ="Informatica Economica" };
            Professor prof2 = new Professor("Ioan Brava") { Faculty = "F.E.A.A.", Specialization = "Informatica Economica" };
            Professor prof3 = new Professor("Adrian Munteanu") { Faculty = "F.E.A.A.", Specialization ="Informatica Economica" };

            prof1.Print();
            prof2.Print();
            prof3.Print();

            Student student1 = new Student() { Name = "Student 1", Faculty = "Informatica economica", Year = 2001 };
            Student student2 = new Student() { Name = "Student 2", Faculty = "Contabilitate si infromatica de gestiune", Year = 2002 };
            Student student3 = new Student() { Name = "Student 3", Faculty = "Informatica economica", Year = 2003 };

            Console.WriteLine("\n {0} \n {1} \n {2}", student1.Print (), student2.Print (), student3.Print ());

            Course curs1 = new Course() { Name = "Baze de date", Year = 2003, numeProf = prof1.Name};
            curs1.Pupil.Add(student1);
            curs1.Pupil.Add(student2);
            curs1.Pupil.Add(student3);

            Console.WriteLine("\n");
            curs1.Print();

            Console.ReadLine();
        }
    }
}
