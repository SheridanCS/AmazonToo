﻿using Microsoft.AspNetCore.Mvc;

namespace AmazonToo.Controllers {

    public class ErrorController : Controller {

        public ViewResult Error() => View();
    }
}
