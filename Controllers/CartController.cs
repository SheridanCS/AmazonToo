using AmazonToo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazonToo.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart(Product product)
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(Product product)
        {
            return RedirectToAction("Index");
        }
    }
}