using AcademicApplication.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AcademicApplication.Models;

namespace AcademicApplication.Areas.Admin.ViewComponents
{
    public class AdminNavBarProfileViewComponent:ViewComponent
    {

        private UserManager<AppUser> _userManager;
        private RoleManager<AppRole> _roleManager;

        public AdminNavBarProfileViewComponent(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<AdminProfileViewModel> GetItemsAsync()
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
                
                }

            }
            return Task.FromResult(model);
        }
    }
}
