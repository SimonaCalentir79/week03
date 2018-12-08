using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class PizzaTopping
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Cost { get; set; }

        public string Print()
        {
            return $"   {Name} -- {Cost} lei";
        }
    }
}
