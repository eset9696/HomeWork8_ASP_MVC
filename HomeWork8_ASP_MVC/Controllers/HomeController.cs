using HomeWork8_ASP_MVC.Services;
using HomeWork8_ASP_MVC.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork8_ASP_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello world!");
        }

        [HttpGet]
        public IActionResult Welcome()
        {
            IGreetingService greetingService = new GreetingService();
            return Content(greetingService.GetGreeting());
        }

        public IActionResult Time()
        {
            return Content(DateTime.Now.ToShortTimeString());
        }
    }
}
