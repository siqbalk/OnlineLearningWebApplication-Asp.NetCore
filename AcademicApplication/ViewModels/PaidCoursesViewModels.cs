using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.ViewModels
{
    public class PaidCoursesViewModels
    {

        public int PaidCoursesId { get; set; }
        public string Course { get; set; }
        public int Price { get; set; }
        public string Appuser { get; set; }
        public int CourseId { get; set; }
        public int Duration { get; set; }
    }
}
