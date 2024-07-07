using Microsoft.EntityFrameworkCore;
using PizzAzureDevops.Models;

namespace PizzAzureDevops.Data
{
    public class PizzAzureContext : DbContext
    {
        public PizzAzureContext(DbContextOptions<PizzAzureContext> options)
            : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }


    }
}
