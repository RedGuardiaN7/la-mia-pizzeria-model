using Pizzeria.Models;

namespace Pizzeria.Utils
{
    public class PizzaData
    {
        private static List<Pizza> pizzas;

        public static List<Pizza> GetPizzas()
        {
            if (pizzas != null) 
            {
                return pizzas;
            }

            pizzas= new List<Pizza>();

            for (int i = 0; i < 8; i++) 
            {
                Pizza NewPizza = new Pizza(i, "Nome pizza" + i, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium.", "https://pizzeria2000.it/wp-content/uploads/2019/10/PROSCIUTTO-600x450.jpg");
                pizzas.Add(NewPizza);
            }

            return pizzas;
        }

    }
}
