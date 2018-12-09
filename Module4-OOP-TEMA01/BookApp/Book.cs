using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    class Book
    {
        public string numeAutor;

        public string Name { get; }
        public Author Writer(string  numeAutor)
        {
            Author newAuth = new Author(numeAutor);
            return newAuth;
        }
        public int Year { get; }
        public double Price { get; }

        public string Print()
        {
            return $"{Name} by {Writer(numeAutor).Name}, {Year} -- {Price} lei";
        }

        public Book (string name, int year, double price)
        {
            this.Name = name;
            this.Year = year;
            this.Price = price;
        }
    }
}
