using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminHome:Controller
    {
        public AdminHome()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
