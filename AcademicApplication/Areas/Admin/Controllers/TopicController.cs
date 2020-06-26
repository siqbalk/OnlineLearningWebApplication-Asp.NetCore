using AcademicApplication.Areas.Admin.ViewModels;
using AcademicApplication.Data;
using AcademicApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class TopicController:Controller
    {
        private IEFRepository _repository;

        public TopicController(IEFRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<TopicCreateViewModel> model = new List<TopicCreateViewModel>();

            var topic = _repository.GetTopics(true);

            if (topic != null)
            {
                model = topic.Select(p => new TopicCreateViewModel()
                {
                    TopicId=p.TopicId,
                    Name=p.Name,
                    ShortDescription=p.ShortDecription,
                    Explanation=p.Explanation,
                    course=p.Course.Title
                }).ToList();
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult TopicCreate()
        {
            TopicCreateViewModel model = null;
            var result = _repository.getCourses(true);
            if (result != null)
            {
                model = new TopicCreateViewModel()
                {
                    Course = result.Select(p => new SelectListItem()
                    {
                        Text = p.Title,
                        Value = p.CourseId.ToString()
                    }).ToList(),
                    Created = DateTime.Now

                };
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult TopicCreate(TopicCreateViewModel model)
        {
            bool Status = false;
            string Message = string.Empty;
            if (ModelState.IsValid)
            {
                var topic = new Topic()
                {
                    Name = model.Name,
                    ShortDecription = model.ShortDescription,
                    Explanation = model.Explanation,
                    Created = model.Created,
                    Course = _repository.GetCourse(model.CourseId, true)

                };

                _repository.Add(topic);

                if (_repository.SaveChange())
                {

                    Status = true;
                    Message = "CourseCreated Successfulllllly";
                    return RedirectToAction("Index", new { area = "Admin", controller = "Topic" });
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
    }
}
