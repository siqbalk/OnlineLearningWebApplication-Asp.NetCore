using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.Admin.ViewModels
{
    public class CourseCreateViewModel
    {

        public CourseCreateViewModel()
        {

        }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} must not exceeds {1} characters")]
        public string Title { get; set; }

        [Display(Name = "Created")]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime Created { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(500, ErrorMessage = "{0} must not exceeds {1} characters")]
        public string ShortDescription { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(500, ErrorMessage = "{0} must not exceeds {1} characters")]
        public string DetailDescription { get; set; }

        [Display(Name = "Is Featured")]
        [Required(ErrorMessage = "{0} is required")]
        public bool IsFeatured { get; set; }

        [Display(Name = "Duration")]
        [Required(ErrorMessage = "{0} is required")]
        public int Duration { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "{0} is required")]
        public int Price { get; set; }

        [Display(Name = "Subject")]
        [Required(ErrorMessage = "{0} is required")]
        public int SubjectId { get; set; }
        public List<SelectListItem> Subjects { get; set; }

        public List<SelectListItem> courses { get; set; }

        public int CourseId { get; set; }
        [Required()]
        public bool Issfeatred { get; set; }
    }
}
