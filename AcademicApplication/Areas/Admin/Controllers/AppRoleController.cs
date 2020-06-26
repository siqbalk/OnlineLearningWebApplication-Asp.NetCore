using AcademicApplication.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AcademicApplication.Models;

namespace AcademicApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AppRoleController:Controller
    {
        private RoleManager<AppRole> _roleManager;

        public AppRoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<AppRoleListViewModel> model = new List<AppRoleListViewModel>();

            var role = _roleManager.Roles;

            model = role.Select(p => new AppRoleListViewModel()
            {
               RoleName=p.Name,
               Description=p.Description,
               Created=p.Created
            }).ToList();


            return View(model);
        }


        [HttpGet]
        public IActionResult RoleCreate()
        {
            AppRoleCreateViewModel model = new AppRoleCreateViewModel()
            {
                Created=DateTime.Now
            };
            return View(model);
        }

        [HttpPost]
        public  IActionResult RoleCreate(AppRoleCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model != null)
                {
                    var result = _roleManager.CreateAsync(new AppRole()
                    {
                        Name = model.Name,
                        Description = model.Description,
                        Created = DateTime.Now

                    }).Result;

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", new { area = "Admin", controller = "AppRole" });

                    }

                }
            }

            ModelState.AddModelError("", "Required info missing");
            return PartialView(model);
        }
    }
}
