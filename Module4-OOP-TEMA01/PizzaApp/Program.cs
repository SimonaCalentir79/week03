using System;
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
            PizzaBase bazaPizza1 = new PizzaBase("Regular") { Cost = 22.10};
            PizzaBase bazaPizza2 = new PizzaBase("Italian") { Cost = 18.10};
            PizzaBase bazaPizza3 = new PizzaBase("Thick") { Cost = 25.10};

            //Console.WriteLine("\n {0} \n {1} \n {2}",bazaPizza1.Print (), bazaPizza2.Print (), bazaPizza3.Print ());

            PizzaTopping topping1 = new PizzaTopping() { Name = "Ciuperci", Cost = 2.5};
            PizzaTopping topping2 = new PizzaTopping() { Name = "Rosii", Cost = 2.5 };
            PizzaTopping topping3 = new PizzaTopping() { Name = "Ardei gras", Cost = 2.5};
            PizzaTopping topping4 = new PizzaTopping() { Name = "Ceapa rosie", Cost = 2.5};

            PizzaTopping topping5 = new PizzaTopping() { Name = "Piept de curcan".ToUpper(), Cost = 4.5};
            PizzaTopping topping6 = new PizzaTopping() { Name = "Prosiciutto".ToUpper(), Cost = 4.5};
            PizzaTopping topping7 = new PizzaTopping() { Name = "Piept de pui".ToUpper(), Cost = 4.5};

            PizzaTopping topping8 = new PizzaTopping() { Name = "Gorgonzola", Cost = 3.5};
            PizzaTopping topping9 = new PizzaTopping() { Name = "Mozzarella", Cost = 3.5};
            PizzaTopping topping10 = new PizzaTopping() { Name = "Grana Padano", Cost = 3.5};

            //Console.WriteLine("\n {0} \n {1} \n {2}",topping1.Print (), topping2.Print (), topping3.Print ());

            Pizza pizza1 = new Pizza() { numeBaza = "Regular", costBaza = 10};
            pizza1.AddPizza("Espagnola");
            pizza1.pizzaToppings.Add(topping1);
            pizza1.pizzaToppings.Add(topping2);
            pizza1.pizzaToppings.Add(topping6);
            pizza1.pizzaToppings.Add(topping9);

            Pizza pizza2 = new Pizza() { numeBaza = "Italian", costBaza = 12 };
            pizza2.AddPizza("Verona");
            pizza2.pizzaToppings.Add(topping3);
            pizza2.pizzaToppings.Add(topping4);
            pizza2.pizzaToppings.Add(topping5);
            pizza2.pizzaToppings.Add(topping8);

            Pizza pizza3 = new Pizza() { numeBaza = "Thik", costBaza = 15};
            pizza3.AddPizza("Florenta");
            pizza3.pizzaToppings.Add(topping2);
            pizza3.pizzaToppings.Add(topping3);
            pizza3.pizzaToppings.Add(topping7);
            pizza3.pizzaToppings.Add(topping10);

            Console.WriteLine("\n");
            pizza1.Print();
            Console.WriteLine("\n");
            pizza2.Print();
            Console.WriteLine("\n");
            pizza3.Print();

            Console.ReadLine();
        }
    }
}
