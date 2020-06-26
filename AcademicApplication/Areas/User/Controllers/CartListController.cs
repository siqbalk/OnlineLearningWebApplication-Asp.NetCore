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
    public class CartListController : Controller
    {
        private IEFRepository _repository;
        private UserManager<AppUser> _userManager;
        public CartListController(IEFRepository repository, UserManager<AppUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<CartListDetailViewModel> model = null;
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var result = _repository.GetCartsByUserId(user.Id, true);

            
            if (result != null)
            {
                model = result.Select(p => new CartListDetailViewModel()
                {
                    CartId = p.CourseCartId,
                    Course = p.course.Title,
                    Created = p.Created,
                    Status = p.course.courseStatus.ToString(),
                    Price = p.Price,
                    Appuser = p.Appuser.UserName
                }).ToList();
            }

            return View(model);
        }
    }
}
