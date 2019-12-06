using Microsoft.AspNetCore.Mvc;
using AmazonToo.Models;

namespace AmazonToo.Controllers
{
    public class ProductsController : Controller
    {
        private AmazonDbContext _context;

        public ProductsController(AmazonDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Details(string productId)
        {
            Product p = _context.Products.Find(productId);
            if (p == null)
            {
                return View("NotFound");
            }
            return View(p);
        }
    }
}