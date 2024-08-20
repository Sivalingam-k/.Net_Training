using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class ProductController : Controller
    {
       
        public IActionResult Index()
        {
            Product product = new Product();
            product.productId = 100;
            product.productName = "Msi Laptop";
            product.productPrice = 10000;
            
            return View(product);
        }
    }
}
