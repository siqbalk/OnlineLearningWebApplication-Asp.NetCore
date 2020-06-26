using AcademicApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.ViewControllers
{
    public class CourseListController:Controller
    {

        public CourseListController()
        {

        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            return ViewComponent("AcademicApplication.ViewComponents.CourseList", new {  id});
        }

        [HttpGet]
        public IActionResult CartShow(int id)
        {
            return ViewComponent("AcademicApplication.ViewComponents.CourseCartDetail",new { id });
        }
    }
}
