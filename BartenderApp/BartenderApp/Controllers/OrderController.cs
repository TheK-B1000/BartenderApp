using BartenderApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BartenderApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly DrinksDb context;

        public OrderController(DrinksDb data)
        {
            context = data;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET
        [HttpGet]
        public IActionResult PlaceOrder()
        {
            var cocktails = context.Cocktails.ToList();
            return View(cocktails);
        }

        // POST
        [HttpPost]
        public IActionResult PlaceOrder(int cocktailID)
        {
            var selectedCocktail = context.Cocktails.Find(cocktailID);

            var newOrder = new Order
            {
                CocktailID = cocktailID,
                CocktailName = selectedCocktail.Name
            };

            context.Orders.Add(newOrder);
            context.SaveChanges();

            return RedirectToAction("Index", "Menu");
        }
    }
}
