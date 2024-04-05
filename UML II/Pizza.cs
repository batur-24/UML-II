using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_II
{
    internal class Pizza
    {

        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public double Price { get; set; }

        public Pizza(string name, List<string> ingredients, double price)
        {
            Name = name;
            Ingredients = ingredients;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - Ingredients: {string.Join(", ", Ingredients)}, Price: kr{Price}";
        }
        public int MenuChoice(List<string> menuItems)
        {
            int choice = -1;
            bool validChoice = false;

            while (!validChoice)
            {
                Console.WriteLine("Please select an option:");
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice >= 1 && choice <= menuItems.Count)
                    {
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            return choice;
        }
    }
}

        
        
          


    
    
      



