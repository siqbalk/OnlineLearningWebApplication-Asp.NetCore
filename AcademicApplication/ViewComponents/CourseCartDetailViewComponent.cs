using AcademicApplication.Data;
using AcademicApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.ViewComponents
{
    public class CourseCartDetailViewComponent:ViewComponent
    {
        private IEFRepository _repository;

        public CourseCartDetailViewComponent(IEFRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            CourseListViewModel model = null;
            var result = _repository.GetCourse(id, true);
            if (result != null)
            {
                model=new CourseListViewModel()
                {
                    CourseId = result.CourseId,
                    Title = result.Title,
                    Duration = result.Duration,
                    IsFeatured = result.IsFeatured,
                    Price = result.Price,
                    Created = result.Created,
                    Description = result.DetailDescription,
                    Subject = result.Subject.Name,
                    SubejctId = result.Subject.SubjectId
                };
            }
            return View(model);
        }
    }
}
