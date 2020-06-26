using AcademicApplication.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AcademicApplication.Data;

namespace AcademicApplication.Areas.Admin.ViewComponents
{
    public class ProgressiveBarViewComponent:ViewComponent
    {
        private IEFRepository _repository;

        public ProgressiveBarViewComponent(IEFRepository repository)
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
            var sales = _repository.GetSalesTarget();
            foreach(var sale in sales)
            {
                count.CartTarget = count.CartCount *100/sale.CartTarget;
                count.SaleTarget = 15*100/sale.SaleTarget;
                count.OrderTarget = 20 *100/sale.OrderTarget;
            }

            return Task.FromResult(count);

        }
    }
}
