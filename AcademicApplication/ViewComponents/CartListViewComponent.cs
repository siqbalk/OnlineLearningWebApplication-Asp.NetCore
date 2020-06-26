using AcademicApplication.Data;
using AcademicApplication.Models;
using AcademicApplication.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.ViewComponents
{
    public class CartListViewComponent:ViewComponent
    {
        private IEFRepository _repository;
        private UserManager<AppUser> _userManager;

        public CartListViewComponent(IEFRepository repository, UserManager<AppUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<CartListViewModel> model = null;

            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var result = _repository.GetCartsByUserId(user.Id, true);
            if (result != null)
            {
                model = result.Select(p => new CartListViewModel()
                {
                    CartId = p.CourseCartId,
                    Course = p.course.Title,
                    Created = p.Created,
                    Status = p.Status.ToString(),
                    Price = p.Price,
                    Appuser = p.Appuser.UserName
                }).ToList();
            }



            return  View(model);
        }


    }
}
