using AcademicApplication.Areas.User.ViewModels;
using AcademicApplication.Data;
using AcademicApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AcademicApplication.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class SubsribeCoursesController:Controller
    {

        private IEFRepository _repository;
        private UserManager<AppUser> _userManager;
        public SubsribeCoursesController(IEFRepository repository, UserManager<AppUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<SubscribeCourseListViewModel> model = new List<SubscribeCourseListViewModel>();
            SubscribeCourseListViewModel sub = new SubscribeCourseListViewModel();
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var result = _repository.GetSubscribedCourses(user.Id, true);

            if (result != null)
            {
                foreach(var subcourse in result)
                {
                        sub = new SubscribeCourseListViewModel()
                        {
                            SubscribeId=subcourse.CourseSubscribeId,
                            Course = subcourse.course.Title,
                                Created = subcourse.Created,
                                Status = subcourse.Status.ToString(),
                               Appuser = subcourse.Appuser.UserName,
                        };

                        model.Add(sub);
                    
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult UnSubscribe(int id)
        {
            var result = _repository.GetSubscribedCours(id, true); 

          if(result == null)
            {
                NotFound("Course Not found");
            }

            //result.IssSubscribe = false;
            _repository.Update(result);

            if (_repository.SaveChange())
            {
                return RedirectToAction("Index", new { area = "User", controller = "SubsribeCourses" });
            }

            return View();

        }
    }
}
