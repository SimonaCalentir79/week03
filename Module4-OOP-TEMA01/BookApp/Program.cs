using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    class Program
    {
        static void Main()
        {
            Author autor1 = new Author("Autor1") { Email = "autor1@email.ro", Country = "Romania"};
            Author autor2 = new Author("Autor2") { Email = "autor2@email.ro", Country = "Romania"};

            Console.WriteLine("\n {0} \n {1}", autor1.Print (), autor2.Print ());
            Console.WriteLine("\n");

            Book book1 = new Book("Titlul 1 (NEd)".ToUpper(),2001,10);
            book1.numeAutor = autor1.Name;
            Book book2 = new Book("Titlul 1 (LEd)".ToUpper(),2003,15);
            book2.numeAutor = autor1.Name;
            Book book3 = new Book("Titlul 2 (NEd)".ToUpper (), 2005, 12);
            book3.numeAutor = autor2.Name;
            Book book4 = new Book("Titlul 2 (LEd)".ToUpper (), 2007, 18);
            book4.numeAutor = autor2.Name;
            Book book5 = new Book("Titlul 3 (NEd)".ToUpper (), 2010, 8);
            book5.numeAutor = autor1.Name;

            Console.WriteLine($" {book1.Print()}");
            Console.WriteLine($" {book2.Print()}");
            Console.WriteLine($" {book3.Print()}");
            Console.WriteLine($" {book4.Print()}");
            Console.WriteLine($" {book5.Print()}");

            Console.ReadLine();
        }
    }
}
