using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_II
{
    internal class MenuCatalog
    {
        private List<Pizza> pizzas;

        public MenuCatalog()
        {
            pizzas = new List<Pizza>();
        }

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }

        public void RemovePizza(string pizzaName)
        {
            pizzas.RemoveAll(pizza => pizza.Name == pizzaName);
        }

        public void UpdatePizza(string pizzaName, Pizza newPizza)
        {
            var pizzaToUpdate = pizzas.FirstOrDefault(pizza => pizza.Name == pizzaName);
            if (pizzaToUpdate != null)
            {
                pizzaToUpdate.Name = newPizza.Name;
                pizzaToUpdate.Ingredients = newPizza.Ingredients;
                pizzaToUpdate.Price = newPizza.Price;
            }
        }

        public Pizza SearchPizza(string criteria)
        {
            return pizzas.FirstOrDefault(pizza => pizza.Name.ToLower(System.Globalization.CultureInfo.CurrentCulture).Contains(criteria.ToLower()));
        }

        public void PrintMenu()
        {
            if (pizzas.Count == 0)
            {
                Console.WriteLine("Menu is empty.");
            }
            else
            {
                Console.WriteLine("Menu:");
                foreach (Pizza pizza in pizzas)
                {
                    Console.WriteLine(pizza);
                }
            }

        }

       
    }

}






