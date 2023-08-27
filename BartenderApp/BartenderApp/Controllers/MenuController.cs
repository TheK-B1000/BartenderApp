using Microsoft.AspNetCore.Mvc;

namespace BartenderApp.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
