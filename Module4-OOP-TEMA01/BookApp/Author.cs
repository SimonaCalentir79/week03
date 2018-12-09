using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public class Author
    {
        public string Name { get; }
        public string Email { get; set; }
        public string Country { get; set; }

        public Author(string numeAutor)
        {
            this.Name = numeAutor;
        }

        public string Print()
        {
            return $"   {Name} {Email} {Country}";
        }
    }
}
