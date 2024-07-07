using Microsoft.AspNetCore.Mvc;
using PizzAzureDevops.Data;
using System.Linq;
using PizzAzureDevops.Services;
namespace PizzAzureDevops.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzAzureContext _context;
 private readonly PizzaService _pizzaService;
        public PizzaController(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        public IActionResult Index()
        {
            var pizzas = _pizzaService.GetAllPizzas();
            return View(pizzas);
        }
    }
}
