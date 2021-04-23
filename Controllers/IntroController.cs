using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Cloud_Site.Controllers
{
    public class IntroController : Controller
    {
        public IActionResult Intro()
        {
            return View();
        }
    }
}
