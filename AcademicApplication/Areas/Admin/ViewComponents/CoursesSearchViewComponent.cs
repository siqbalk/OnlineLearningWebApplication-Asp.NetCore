using AcademicApplication.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using AcademicApplication.Data;

namespace AcademicApplication.Areas.Admin.ViewComponents
{
    public class CoursesSearchViewComponent:ViewComponent
    {
        private IEFRepository _repository;

        public CoursesSearchViewComponent(IEFRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private  Task<CourseCreateViewModel> GetItemsAsync()
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

                };
            }

            return Task.FromResult(model);
        }
    }
}
