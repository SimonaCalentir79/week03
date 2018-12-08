using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class PizzaBase
    {
        public string Name { get; }
        public double Cost { get; set; }

        public PizzaBase(string numeBaza)
        {
            this.Name = numeBaza;
        }

        public string Print()
        {
            return $"   Base {Name} --> {Cost} lei";
        }
    }
}
