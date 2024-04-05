using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_II
{
    internal class Order
    {
        public Pizza Pizza { get; set; }
        public Customer Customer { get; set; }
        public int OrderNumber { get; set; }

        public List<Pizza> Pizzas { get; set; }

        public Order(Pizza pizza, Customer customer)
        {
            Pizza = pizza;
            Customer = customer;
        }

        public double CalculateTotalPrice()
        {
            // Assuming 38% tax og 40 kr. from delivery.

            const double taxRate = 0.38;
            const double deliveryCost = 40;
            double totalPrice = Pizza.Price + (Pizza.Price * taxRate) + deliveryCost;
            return totalPrice;
        }



        public Order(int orderNumber, Customer customer, List<Pizza> pizzas)
        {
            OrderNumber = orderNumber;
            Customer = customer;
            Pizzas = pizzas;
        }

        public override string ToString()
        {
            return $"{Pizza.ToString()}, {Customer.ToString()}, Total Price: {CalculateTotalPrice()}";
        }
    }
}

