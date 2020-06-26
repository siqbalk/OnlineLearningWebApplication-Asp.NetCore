using AcademicApplication.Areas.Admin.ViewModels;
using AcademicApplication.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class TopicExplanationController:Controller
    {
        private IEFRepository _repository;

        public TopicExplanationController(IEFRepository  repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            TopicCreateViewModel model = new TopicCreateViewModel();

            var topic = _repository.GetTopic(id, true);

            if (topic != null)
            {
                model = new TopicCreateViewModel()
                {
                    TopicId = topic.TopicId,
                    Name = topic.Name,
                    ShortDescription = topic.ShortDecription,
                    Explanation = topic.Explanation,
                    course = topic.Course.Title
                };
            }

            return View(model);
        }
    }

}
