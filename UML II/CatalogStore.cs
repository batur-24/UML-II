using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_II
{
    internal class CatalogStore
    {
        // en method som indholde alle objekt, method kan kalde i program.
        public void System()
        {
            // laver objekt 

            //  MenuCatalog menuCatalog = new MenuCatalog();
            // Pizza pizza1 = new Pizza(10, "Hawii", "øst,kylling,tomatsoce og dressing", 75);
            // menuCatalog.AddPizza(pizza1); 
            // MenuCatalog menuCatalog2 = new MenuCatalog();
            // menuCatalog.UpdatePizza(2, "Hawii", "øst", 55);


            // Creating some pizza objects
            Pizza pizza1 = new Pizza("Hawii", new List<string> { "tomato sauce", "mozzarella", "basil" }, 80);
            Pizza pizza2 = new Pizza("Cicilia", new List<string> { "tomato sauce", "mozzarella", "pepperoni" }, 75);
            Pizza pizza3 = new Pizza("Vegetarian", new List<string> { "tomato sauce", "mozzarella", "bell peppers", "olives", "onions" }, 90);


            // 

            Console.Write("Write your name please: ");
            string name = Console.ReadLine();
            Console.Write("wath is your mobil nr ?:  ");
            int mobilNr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hi" + name + " Welcome to Big Mamma Pizzaria");


            // Creating a menu catalog
            MenuCatalog menu = new MenuCatalog();

            

            // Adding pizzas to the menu
            menu.AddPizza(pizza1);
            menu.AddPizza(pizza2);
            menu.AddPizza(pizza3);

            // Printing the menu
            menu.PrintMenu();

            // Searching for a pizza
            Pizza searchedPizza = menu.SearchPizza("margherita");
            if (searchedPizza != null)
            {
                Console.WriteLine($"\nSearched Pizza Found: {searchedPizza}");
            }
            else
            {
                Console.WriteLine("\nSearched Pizza Not Found: {Error}");
            }

            // Updating a pizza
            Pizza updatedPizza = new Pizza("Margherita Special", new List<string> { "Kylling", "mozzarella", "salat", "extra cheese" }, 90);
            menu.UpdatePizza("Margherita", updatedPizza);

            // Removing a pizza
            menu.RemovePizza("Vegetarian");

            // Printing the updated menu
            Console.WriteLine("\nUpdated Menu:");
            menu.PrintMenu();

        }
    }


}
    

