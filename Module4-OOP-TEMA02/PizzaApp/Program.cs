﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Program
    {
        static void Main()
        {
            var newPizza = new Pizza();
            newPizza.CreatePizza();

            newPizza.Print();

            Console.ReadLine();
        }
    }
}
