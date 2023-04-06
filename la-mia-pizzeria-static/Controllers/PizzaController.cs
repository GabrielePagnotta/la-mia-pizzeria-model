using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using var ctx = new DbPizzaContext();
            var pizza= ctx.Pizzas.ToArray();
            return View("bo",pizza);
        }
    }
}
