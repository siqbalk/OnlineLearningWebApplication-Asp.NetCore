using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.User.ViewModels
{
    public class SubscribeCourseListViewModel
    {
        public int SubscribeId { get; set; }
        public string Course { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
        public int  Price { get; set; }
        public string Appuser { get; set; }
        public string  Subject { get; set; }
    }
}
