using AcademicApplication.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AcademicApplication.Data;

namespace AcademicApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CartListController:Controller
    {
        private IEFRepository _reopistory;

        public CartListController(IEFRepository reopistory)
        {
            _reopistory = reopistory;
        }

        [HttpGet]
        public IActionResult Index()
        {

            List<CourseCartListViewModel> model = new List<CourseCartListViewModel>();

            var Cartlist = _reopistory.GetCarts(true);

            if(Cartlist != null)
            {
                model = Cartlist.Select(p => new CourseCartListViewModel()
                {
                    CartId=p.CourseCartId,
                    CourseName=p.course.Title,
                    CoursePrice=p.Price,
                    User=p.Appuser.UserName,
                    
                }).ToList();
            }


            return View();
        }
    }
}
