using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Controllers
{
    [Authorize(Roles = "User")]
    public class ShoppingController:Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
