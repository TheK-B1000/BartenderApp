using Microsoft.AspNetCore.Mvc;

namespace BartenderApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
