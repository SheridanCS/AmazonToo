using AmazonToo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazonToo.Controllers
{
    class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart(Product product)
        {
            return View();
        }

        [HttpPost]
        public IActionResult RemoveFromCart(Product product)
        {
            return View();
        }
    }
}