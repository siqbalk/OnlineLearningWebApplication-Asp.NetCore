using AcademicApplication.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AcademicApplication.Models;

namespace AcademicApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminProfileController:Controller
    {
        private UserManager<AppUser> _userManager;

        public AdminProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var model = new AdminProfileViewModel();
            var users = _userManager.GetUsersInRoleAsync("Admin").Result;
            if (users != null)
            {
                foreach (var user in users)
                {
                    model.FirstName = user.FirstName;
                    model.LastName = user.LastName;
                    model.Email = user.Email;
                    model.AvatarImage = user.AvatarImage;
                    model.PhoneNo = "03365790201";
                    
                }

            }
            return View(model);
        }
    }
}
