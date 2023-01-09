using Microsoft.AspNetCore.Mvc;
using Pizzeria.Models;
using Pizzeria.Utils;

namespace Pizzeria.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> PizzaList = PizzaData.GetPizzas();
            return View("Index", PizzaList);
        }
    }
}
