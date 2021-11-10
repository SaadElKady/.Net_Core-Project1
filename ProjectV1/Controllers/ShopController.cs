using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectV1.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult ViewShop()
        {
            return View();
        }
    }
}
