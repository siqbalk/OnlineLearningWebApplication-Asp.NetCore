using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.Admin.ViewModels
{
    public class DashBoardCountViewModel
    {
        public DashBoardCountViewModel()
        {

        }

        public int CourseCount { get; set; }
        public int SubjectCount { get; set; }
        public int UserCount { get; set; }
        public int CartCount { get; set; }
        public int RoleCount { get; set; }
        public int TopicCount { get; set; }
        public int CartTarget { get; set; }
        public int SaleTarget { get; set; }
        public int OrderTarget { get; set; }
    }
}
