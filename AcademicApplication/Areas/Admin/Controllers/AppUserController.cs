using AcademicApplication.Areas.Admin.ViewModels;
using AcademicApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class AppUserController : Controller
    {
        private UserManager<AppUser> _userManager;
        private RoleManager<AppRole> _roleManager;

        public AppUserController(
            UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult AllUserList()
        {
            List<UserListViewModel> userlist = new List<UserListViewModel>();
            UserListViewModel model = new UserListViewModel();
            List<string> Rolelist = new List<string>();

            var users = _userManager.Users;
            foreach (var user in users)
            {
                var findroles = _userManager.GetRolesAsync(user).Result;
                if (findroles != null)
                {
                    foreach (var role in findroles)
                    {
                        if (_userManager.IsInRoleAsync(user, role).Result)
                        {
                            Rolelist.Add(role);
                            model = new UserListViewModel()
                            {
                                AppUserId = user.Id,
                                FirstName = user.FirstName,
                                LastName = user.LastName,
                                Email = user.Email,
                                PhoneNo = user.PhoneNumber,
                                Created = user.Created,
                                Roles=Rolelist
                            };

                        }

                        userlist.Add(model);
                    }
                }
                else
                {
                    model = new UserListViewModel()
                    {
                        AppUserId = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        PhoneNo = user.PhoneNumber,
                        Created = user.Created,
                        role = "Not in role"
                    };
                }

            }
            return View(userlist);
        }

        [HttpGet]
        public IActionResult AddAppUser()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> AddAppUser(AddUserViewModel model)
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "invalid or incomplete information");
            }

            if(model == null)
            {
                return NotFound("Empty data found");
            }
            else
            {
                var user = new AppUser
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Created = DateTime.Now,
                    UserName = model.Email,
                    Email = model.Email
                };


                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("NotinRole", new { area = "Admin", controller = "UserList" });
                }
            }

           
            return PartialView(model); 
        }

        [HttpGet]
        public IActionResult DeleteUser(string id)
        {
            bool Status = false;
            string Message = string.Empty;
            var user = _userManager.FindByIdAsync(id).Result;
            if (user == null)
            {
                NotFound("user not found");
            }

            var result =  _userManager.DeleteAsync(user).Result;

            if (result.Succeeded)
            {
                Status = true;
                Message = "User deleted successfuly";
                return RedirectToAction("Index", new { area = "Admin", controller = "AppUser" });
            }
            else
            {
                Status = false;
                Message = "Error deleting user";
                return RedirectToAction("Index", new { area = "Admin", controller = "AppUser" });
            }

            return Json(new { status = Status, message = Message });
        }
    }
}
