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

        public IActionResult Details(int id) 
        {
            List<Pizza> PizzaList = PizzaData.GetPizzas();

            foreach(Pizza pizza in PizzaList) 
            {
                if(pizza.Id == id)
                {
                    return View(pizza);
                }
            }

            return NotFound("La pizza che stai cercando non esiste!");
        }
    }
}
