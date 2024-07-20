using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index(string message = "Your PC ran into a problem and needs to restart. We're just collecting some error info, and then we'll restart for you.")
        {
            ViewBag.Message = message;
            return View();
        }
    }
}
