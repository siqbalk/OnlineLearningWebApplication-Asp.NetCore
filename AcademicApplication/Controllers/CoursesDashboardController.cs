using Microsoft.AspNetCore.Mvc;

namespace AcademicApplication.ViewControllers
{
    public class CoursesDashboardController:Controller
    {

        public CoursesDashboardController()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
