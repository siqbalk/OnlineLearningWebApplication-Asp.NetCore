using Microsoft.AspNetCore.Mvc;

namespace AcademicApplication.Areas.Admin.Controllers
{
    public class UserStatisticallRecordController:Controller
    {
        public UserStatisticallRecordController()
        {


        }

        [HttpGet]
       public IActionResult Index()
        {
            return View();
        }
    }
}
