using PizzAzureDevops.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzAzureDevops.Services
{
    public class PizzaService
    {
        private readonly List<Pizza> _pizzas;

        public PizzaService()
        {
            _pizzas = new List<Pizza>
            {
                new Pizza { Name = "Margherita", Description = "Classic pizza with tomato sauce and cheese", Price = 7.99m },
                new Pizza { Name = "Pepperoni", Description = "Pepperoni and cheese", Price = 8.99m },
                new Pizza { Name = "Hawaiian", Description = "Ham and pineapple", Price = 9.99m }
            };
        }

        public List<Pizza> GetAllPizzas()
        {
            return _pizzas.ToList();
        }
    }
}
