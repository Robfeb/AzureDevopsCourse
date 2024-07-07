using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PizzAzureDevops.Models;
using System;
using System.Linq;

namespace PizzAzureDevops.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PizzAzureContext(
                serviceProvider.GetRequiredService<DbContextOptions<PizzAzureContext>>()))
            {
                // Check if the database is already seeded
                if (context.Pizzas.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pizzas.AddRange(
                    new Pizza
                    {
                        Name = "Margherita",
                        Description = "Classic pizza with tomato sauce and cheese",
                        Price = 7.99m
                    },
                    new Pizza
                    {
                        Name = "Pepperoni",
                        Description = "Pepperoni and cheese",
                        Price = 8.99m
                    },
                    new Pizza
                    {
                        Name = "Hawaiian",
                        Description = "Ham and pineapple",
                        Price = 9.99m
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
