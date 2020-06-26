using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.ViewModels
{
    public class CartListDetailViewModel
    {
        public int CartId { get; set; }
        public string Course { get; set; }
        public DateTime Created { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public string Appuser { get; set; }
        public byte[] CourseImage { get; set; }
    }
}
