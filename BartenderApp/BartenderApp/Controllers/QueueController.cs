using Microsoft.AspNetCore.Mvc;

namespace BartenderApp.Controllers
{
    public class QueueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
