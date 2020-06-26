using AcademicApplication.Data;
using AcademicApplication.Models;
using AcademicApplication.ViewModels;
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
    public class PaidCoursesController:Controller
    {
        private IEFRepository _repository;
        private UserManager<AppUser> _userManager;

        public PaidCoursesController(IEFRepository repository,UserManager<AppUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var user = _userManager.GetUserAsync(User).Result;
            List<PaidCoursesViewModels> model = null;

            var result = _repository.GetPaidCoursesByUserId(user.Id, true);

            if (result != null)
            {
                model = result.Select(p => new PaidCoursesViewModels()
                {
                    PaidCoursesId = p.PaidCoursesId,
                    Course = p.course.Title,
                    Price = p.Price,
                    Appuser = p.Appuser.UserName,
                    CourseId=p.course.CourseId,
                    Duration=p.course.Duration
                }).ToList();

                
            }
            return View(model);
        }
    }
}
