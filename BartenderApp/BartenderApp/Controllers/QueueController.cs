using BartenderApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BartenderApp.Controllers
{
    public class QueueController : Controller
    {

        private readonly DrinksDb context;
        public QueueController(DrinksDb data)
        {
            context = data;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
