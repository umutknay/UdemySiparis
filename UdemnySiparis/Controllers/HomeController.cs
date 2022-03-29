using Microsoft.AspNetCore.Mvc;

namespace UdemnySiparis.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
