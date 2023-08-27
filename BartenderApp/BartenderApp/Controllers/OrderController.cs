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
    }
}
