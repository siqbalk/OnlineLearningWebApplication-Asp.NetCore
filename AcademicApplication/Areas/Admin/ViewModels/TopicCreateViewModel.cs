using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.Admin.ViewModels
{
    public class TopicCreateViewModel
    {

        public TopicCreateViewModel()
        {
            Course = new List<SelectListItem>();
        }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} must not exceeds {1} characters")]
        public string Name { get; set; }

        [Display(Name = "Created")]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime Created { get; set; }

        [Display(Name = "ShortDescription")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(500, ErrorMessage = "{0} must not exceeds {1} characters")]
        public string ShortDescription { get; set; }


        [Display(Name = "Explanation")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(7000, ErrorMessage = "{0} must not exceeds {1} characters")]
        public string Explanation { get; set; }




        [Display(Name = "Subject")]
        [Required(ErrorMessage = "{0} is required")]
        public int CourseId { get; set; }
        public List<SelectListItem> Course { get; set; }

        public int TopicId { get; set; }

        public string  course { get; set; }
    }
}
