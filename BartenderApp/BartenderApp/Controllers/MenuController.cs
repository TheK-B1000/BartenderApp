using BartenderApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BartenderApp.Controllers
{
    public class MenuController : Controller
    {

        private readonly DrinksDb context;

        public MenuController(DrinksDb data)
        {
            context = data;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
