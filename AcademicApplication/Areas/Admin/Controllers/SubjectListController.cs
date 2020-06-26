using AcademicApplication.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AcademicApplication.Data;
using AcademicApplication.Models;

namespace AcademicApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SubjectListController : Controller
    {
        private IEFRepository _repository;

        public SubjectListController(IEFRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<SubjectListViewModel> model = new List<SubjectListViewModel>();

            var subject = _repository.GetSubjects(true);

            if (subject != null)
            {
                model = subject.Select(p => new SubjectListViewModel()
                {
                    SUbjectId=p.SubjectId,
                    SubjectName = p.Name
                }).ToList();
            }

            return View(model);
        }


        #region SubjectCreat
        [HttpGet]
        public IActionResult SubjectCreate()
        {
            return View();

        }

        [HttpPost]
        public IActionResult SubjectCreate(SubjectCreateViewModel model)
        {


            bool Status = false;
            string Message = string.Empty;
            if (ModelState.IsValid)
            {
                var subject = new Subject()
                {
                    Name = model.SubjectName,
                    Created = DateTime.Now
                };

                _repository.Add(subject);

                if (_repository.SaveChange())
                {
                    Status = true;
                    Message = "SubjectCreated Successfulllllly";
                    return RedirectToAction("Index", new { area = "Admin", controller = "SubjectList" });
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
        #endregion
    }
}
