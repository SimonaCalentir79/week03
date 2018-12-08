using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class Pizza
    {
        public string numeBaza;
        public double costBaza;

        string Name { get; set; }
        public PizzaBase Base(string numeBaza, double costBaza)
        {
            PizzaBase bazaPzz = new PizzaBase(numeBaza) { Cost = costBaza};
            return bazaPzz;
        }
        public List<PizzaTopping> pizzaToppings = new List<PizzaTopping>();

        public void AddPizza(string numePizza)
        {
            this.Name = numePizza;
        }

        public double CalculateTotalCost()
        {
            double x = 0;
            double y = 0;
            foreach (var top in pizzaToppings)
                x = x + top.Cost;
            y = x + Base(numeBaza,costBaza).Cost;
            return y;
        }

        public void Print()
        {
            Console.WriteLine($"   Pizza: {Name.ToUpper()}");
            Console.WriteLine($"      Base: {numeBaza} ({costBaza} lei)");
            Console.WriteLine($"      Toppings:");
            foreach (var top in pizzaToppings)
                Console.WriteLine($"         {top.Name} ({top.Cost} lei)");
            Console.WriteLine($"   Total cost: {CalculateTotalCost()} lei");
        }
    }
}
