using BartenderApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public ActionResult PlaceOrder(int cocktailID)
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
