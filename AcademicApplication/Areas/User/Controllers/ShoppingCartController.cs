using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class ShoppingCartController:Controller
    {

        public ShoppingCartController()
        {
                
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
