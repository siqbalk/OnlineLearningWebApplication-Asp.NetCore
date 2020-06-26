using AcademicApplication.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AcademicApplication.Models;

namespace AcademicApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserListController : Controller
    {
        private UserManager<AppUser> _userManager;
        private RoleManager<AppRole> _roleManager;

        public UserListController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        #region ApplicationUser
        [HttpGet]
        public IActionResult Index()
        {
            int count = 0;
            List<UserListViewModel> list = new List<UserListViewModel>();
            UserListViewModel model = new UserListViewModel();

            var users = _userManager.Users;
            var roles = _roleManager.Roles;


            foreach (var user in users)
            {
                var findRoles = _userManager.GetRolesAsync(user).Result;

                if (findRoles != null)
                {


                    foreach (var findrole in findRoles)
                    {

                        if ((_userManager.IsInRoleAsync(user, findrole).Result) && (findrole == "User"))
                        {
                            count++;
                        }



                        if (count > 0)
                        {
                            model = new UserListViewModel()
                            {
                                AppUserId = user.Id,
                                FirstName = user.FirstName,
                                LastName = user.LastName,
                                Email = user.Email,
                                PhoneNo = user.PhoneNumber,
                                Created = user.Created,
                                role = findrole
                            };

                            list.Add(model);
                            count = 0;
                        }
                    }
                }


            }

            return View(list);
        }

        #endregion

        #region NotinRole User

        [HttpGet]
        public IActionResult NotinRole()
        {
            bool isInrole = false;
            int count = 0;
            List<UserListViewModel> list = new List<UserListViewModel>();
            UserListViewModel model = new UserListViewModel();

            var users = _userManager.Users;
            var roles = _roleManager.Roles;

            foreach (var user in users)
            {
                foreach (var role in roles)
                {
                    isInrole = _userManager.IsInRoleAsync(user, role.Name).Result;

                    if (isInrole == true)
                    {
                        count++;
                    }

                }

                if (count == 0)
                {
                    model = new UserListViewModel()
                    {
                        AppUserId = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        PhoneNo = user.PhoneNumber,
                        Created = user.Created
                    };

                    list.Add(model);
                }
                count = 0;
            }

            return View(list);
        }



        #endregion

        #region Managerial User
        [HttpGet]
        public IActionResult ManagerialUser()
        {
            int count = 0;
            List<UserListViewModel> userList = new List<UserListViewModel>();
            UserListViewModel model = new UserListViewModel();

            var users = _userManager.Users;
            var roles = _roleManager.Roles;


            foreach (var user in users)
            {
                var findRoles = _userManager.GetRolesAsync(user).Result;

                if (findRoles != null)
                {


                    foreach (var findrole in findRoles)
                    {

                        if ((_userManager.IsInRoleAsync(user, findrole).Result) && (findrole != "User"))
                        {
                            count++;
                        }



                        if (count > 0)
                        {
                            model = new UserListViewModel()
                            {
                                AppUserId = user.Id,
                                FirstName = user.FirstName,
                                LastName = user.LastName,
                                Email = user.Email,
                                PhoneNo = user.PhoneNumber,
                                Created = user.Created,
                                role = findrole
                            };

                            userList.Add(model);
                            count = 0;
                        }



                    }
                }


            }

            return View(userList);
        }

        #endregion
    }
}
