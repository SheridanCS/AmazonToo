using Microsoft.AspNetCore.Mvc;

namespace AmazonToo.Controllers
{
    public class ProductsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}