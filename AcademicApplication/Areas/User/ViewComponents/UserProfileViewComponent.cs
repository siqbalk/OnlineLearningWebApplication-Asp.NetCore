using AcademicApplication.Areas.User.ViewModels;
using AcademicApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.User.ViewComponents
{
    public class UserProfileViewComponent:ViewComponent
    {
        private UserManager<AppUser> _userManager;

        public UserProfileViewComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
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
