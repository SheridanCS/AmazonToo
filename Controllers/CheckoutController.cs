using Microsoft.AspNetCore.Mvc;

namespace AmazonToo.Controllers
{
    public class CheckoutController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}