using Microsoft.AspNetCore.Mvc;

namespace partialViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Discovery()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}