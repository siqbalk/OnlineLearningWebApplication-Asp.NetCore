using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.Admin.ViewModels
{
    public class CourseCartListViewModel
    {

        public CourseCartListViewModel()
        {

        }

        public int CartId { get; set; }

        public string  CourseName { get; set; }

        public int CoursePrice { get; set; }

        public string  CourseStatus { get; set; }

        public string  User { get; set; }
    }
}
