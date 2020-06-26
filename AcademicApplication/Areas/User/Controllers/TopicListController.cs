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
    public class TopicListController:Controller
    {
        private IEFRepository _repository;

        public TopicListController(IEFRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            
            List<TopicCreateViewModel> model = new List<TopicCreateViewModel>();

            var topic = _repository.GetTopics(id, true);

            if (topic != null)
            {
                model = topic.Select(p => new TopicCreateViewModel()
                {
                    TopicId = p.TopicId,
                    Name = p.Name,
                    ShortDescription = p.ShortDecription,
                    Explanation = p.Explanation,
                    course = p.Course.Title
                }).ToList();
            }

            return View(model);
        }
    }
}
