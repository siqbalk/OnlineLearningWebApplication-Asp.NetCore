using AcademicApplication.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AcademicApplication.Data;

namespace AcademicApplication.Areas.Admin.ViewComponents
{
    public class PieChartViewComponent:ViewComponent
    {
        private IEFRepository _repository;

        public PieChartViewComponent(IEFRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync();
            return View(items);
        }

        private Task<DashBoardCountViewModel> GetItemsAsync()
        {
            var count = new DashBoardCountViewModel();
            count.CartCount = _repository.CartCount();
            count.SubjectCount = _repository.SubjectCount();
            count.CourseCount = _repository.CoursesCount();
            count.UserCount = _repository.UserCount();
            count.RoleCount = _repository.RoleCount();
            count.TopicCount = _repository.TopicCount();

            return Task.FromResult(count);

        }
    }
}
