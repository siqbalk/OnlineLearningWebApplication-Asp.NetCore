using AcademicApplication.Data;
using AcademicApplication.Models;
using AcademicApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.ViewComponents
{
    public class CourseListViewComponent:ViewComponent
    {

        private IEFRepository _repository;
        public CourseListViewComponent(IEFRepository repository)
        {
            _repository = repository;
        }


        public async Task<IViewComponentResult> InvokeAsync(int id)
        {

            List<CourseListViewModel> model = new List<CourseListViewModel>();
            CourseListViewModel course = new CourseListViewModel();
            var result = _repository.GetCoursesBySubejctId(id, true);
            if (result != null)
            {

                foreach (var courses in result)
                {
                    if (courses.IsPaid == false)
                    {
                        course = new CourseListViewModel()
                        {
                            CourseId = courses.CourseId,
                            Title = courses.Title,
                            Duration = courses.Duration,
                            IsFeatured = courses.IsFeatured,
                            Price = courses.Price,
                            Created = courses.Created,
                            Description = courses.DetailDescription,
                            ShortDesc = courses.ShortDescription,
                            Subject = courses.Subject.Name,
                            SubejctId = courses.Subject.SubjectId,
                            Image=courses.Image
                        };
                        model.Add(course);
                    }
                }

            }
            return View(model);
        }

       
    }
}
