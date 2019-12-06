using AmazonToo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazonToo.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            return View();
        }

        public IActionResult Me()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddAddress()
        {
            return View();
        }

        public IActionResult AddAddress(UserAddress userAddress)
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditAddress()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditAddress(UserAddress userAddress)
        {
            return View();
        }
    }
}