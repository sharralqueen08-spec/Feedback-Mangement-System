using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Feedback()
        {
            return View();
        }


    }
}
