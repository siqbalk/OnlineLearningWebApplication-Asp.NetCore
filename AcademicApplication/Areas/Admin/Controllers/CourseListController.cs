using AcademicApplication.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using AcademicApplication.Data;
using AcademicApplication.Models;

namespace AcademicApplication.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CourseListController:Controller
    {
        private IEFRepository _repository;

        public CourseListController(IEFRepository repository)
        {
            _repository = repository;
        }



        [HttpGet]
        public IActionResult Index(QueryOptions options,CourseCreateViewModel model)
        {
            return View(_repository.GetCourses(options,model.SubjectId,model.Price,model.CourseId, true));
        }

      

        //[HttpGet]
        //public IActionResult Index(QueryOptions options)
        //{
        //    List<CourseListViewModel> model = new List<CourseListViewModel>();

        //    var courses = _repository.GetCourses(options, true);

        //    if (courses != null)
        //    {
        //        model = courses.Select(p => new CourseListViewModel()
        //        {
        //            CourseId = p.CourseId,
        //            Title = p.Title,
        //            Subject = p.Subject.Name,
        //            Price = p.Price,

        //        }).ToList();
        //    }

        //    return View(model);

        //}

        [HttpGet]
        public IActionResult CourseCreate()
        {
            CourseCreateViewModel model = null;
            var result = _repository.GetSubjects(true);
            if (result != null)
            {
                model = new CourseCreateViewModel()
                {
                    Subjects = result.Select(p => new SelectListItem()
                    {
                        Text = p.Name,
                        Value = p.SubjectId.ToString()
                    }).ToList(),
                    Created = DateTime.Now

                };
            }

            return View(model);

        }

        [HttpPost]

        public IActionResult CourseCreate(CourseCreateViewModel model)
        {
            bool Status = false;
            string Message = string.Empty;
            if (ModelState.IsValid)
            {
                var course = new Course()
                {
                    Title = model.Title,
                    ShortDescription = model.ShortDescription,
                    DetailDescription = model.DetailDescription,
                    Price = model.Price,
                    IsFeatured = model.IsFeatured,
                    Created = model.Created,
                    Duration = model.Duration,
                    courseStatus=CourseStatus.Active,
                    IsPaid = false,
                    Subject = _repository.GetSubject(model.SubjectId, true)

                };

                _repository.Add(course);

                if (_repository.SaveChange())
                {

                    Status = true;
                    Message = "CourseCreated Successfulllllly";
                    return RedirectToAction("Index", new { area = "Admin", controller = "CourseList" });
                }
                else
                {
                    Status = false;
                    Message = "Error inserting /Creating Course";
                }
            }
            else
            {
                ModelState.AddModelError("", "invalid / incomplete data");
            }
            return Json(new { status = Status, message = Message });
        }

        //[HttpPost]
        //public IActionResult Search(Course course)
        //{

        //    var product=_repository.GetFilteredCourse(course.Subject.Name, course.Price);
        //    return View(product);
        //}
    }
}
