using Microsoft.AspNetCore.Mvc;

namespace AmazonToo.Controllers
{
    public class UsersController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}