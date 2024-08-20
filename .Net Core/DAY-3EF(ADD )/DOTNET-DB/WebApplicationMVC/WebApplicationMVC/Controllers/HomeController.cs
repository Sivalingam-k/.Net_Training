using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Diagnostics;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        private CompanyContext companyContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,CompanyContext cc)
        {
            _logger = logger;
            companyContext = cc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public string CreateInformation() {
            var info = new Information()
            {
                name = "Siva",
                License = "xxxx",
                Revenue = 10000,
                Established = Convert.ToDateTime("20/10/2000")
            };
            companyContext.Entry(info).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            companyContext.SaveChanges();
            return "Added Successfully";
        }
    }
}
