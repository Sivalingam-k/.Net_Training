using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class CalculateController : Controller
    {
        
        public IActionResult Info()
        {
         
            Person person = new Person();
            person.name = "Shiva Lingam";
            person.basicSalary = 10000;
            person.age = 23;
            return View(person);
        }
        public IActionResult Index()
        {
            //Dynamic Data
            ViewBag.Heading = "Hey Action Generated from my Calculator";
            return View();
        }
        public IActionResult Greetings()
        {
            return View();
        }
    }
}
