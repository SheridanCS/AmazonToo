using Microsoft.AspNetCore.Mvc;

namespace AmazonToo.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string productId)
        {
            return View();
        }
    }
}