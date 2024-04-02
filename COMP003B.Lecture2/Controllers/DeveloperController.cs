using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Lecture2.Controllers
{
    public class DeveloperController : Controller
    {
        // GET "Developer/Index"
        public IActionResult Index()
        {
            return View();
        }

        // GET "Developer/AboutMe"
        public IActionResult AboutMe()
        {
            return View();
        }
    }
}
