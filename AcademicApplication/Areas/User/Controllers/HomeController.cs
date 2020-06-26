using AcademicApplication.Areas.User.ViewModels;
using AcademicApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class HomeController:Controller
    {
        private UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {

            UserPofileViewModel model = null;

            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var roles = _userManager.GetRolesAsync(user).Result;


            if (user != null)
            {
                model = new UserPofileViewModel()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    PhoneNo = user.PhoneNumber,
                    AvatarImage = user.AvatarImage,
                    Password=user.PasswordHash,
                    ConfirmaPassword=user.PasswordHash
                };

            }
            if (roles != null)
            {
                foreach (var Role in roles)
                {
                    model.role = Role;

                }
            }


            return View(model);
        }
    }
}
