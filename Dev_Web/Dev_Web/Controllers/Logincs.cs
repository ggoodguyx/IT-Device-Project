using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Web.Controllers
{
    public class Logincs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
