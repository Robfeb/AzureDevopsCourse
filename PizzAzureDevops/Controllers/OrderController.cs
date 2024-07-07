using Microsoft.AspNetCore.Mvc;
using PizzAzureDevops.Data;
using PizzAzureDevops.Models;
using PizzAzureDevops.Services;
using System.Linq;

namespace PizzAzureDevops.Controllers
{
    public class OrderController : Controller
    {
        private readonly PizzAzureContext _context;
private readonly PizzaService _pizzaService;
        public OrderController(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        

        public IActionResult Create(int pizzaId)
        {
            var pizzas = _pizzaService.GetAllPizzas();
            var pizza = pizzas.FirstOrDefault(p => p.Id == pizzaId);
            if (pizza == null)
            {
                return NotFound();
            }
            var order = new Order { PizzaId = pizzaId, Pizza = pizza };
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index), "Pizza");
            }
            return View(order);
        }
    }
}
