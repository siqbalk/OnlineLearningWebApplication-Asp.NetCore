using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.ViewModels
{
    public class CourseListViewModel
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string  ShortDesc { get; set; }
        public DateTime Created { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
        public bool IsFeatured { get; set; }
        public int SubejctId { get; set; }
        public byte[] CourseImage { get; set; }

        public string  Image { get; set; }
    }
}
