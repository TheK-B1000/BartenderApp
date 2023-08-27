using BartenderApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BartenderApp.Controllers
{
    public class MenuController : Controller
    {

        private readonly DrinksDb context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
