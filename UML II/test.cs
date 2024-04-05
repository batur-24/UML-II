using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_II
{
    internal class Test
    {
        //Pizza pizza1 = new Pizza(10, "Hawii", "øst,kylling,tomatsoce og dressing", 75);
        //Pizza pizza2 = new Pizza(2, "Sicilain", "mosaghala, paparoni og cheada øst", 80);
        //Pizza pizza3 = new Pizza(22, "Vegetarian", "Tomatoes, onions,herbs og hvidløg", 85);

        List<Pizza> pizzaList = new List<Pizza>();

      
        // create 
        public void AddPizza(Pizza pizza)
        {
            pizzaList.Add(pizza);
        }
        public void DeletePizza(Pizza pizza)
        {
            pizzaList.Remove(pizza);
        }
        public void UpdatePizza(int num, string name, string ingrediance, double price)
        {
            foreach (Pizza pizza in pizzaList)
            {
                if (pizza.Name == name)
                {
                  //  pizza.PizzaNum = num;
                  //  pizza.Ingrediance = ingrediance;
                    pizza.Price = price;
                    pizza.Name = name;
                }
               
            }
        }
    }
}
