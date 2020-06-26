using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.Admin.ViewModels
{
    public class AppRoleCreateViewModel
    {

        public AppRoleCreateViewModel()
        {

        }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }


        [Display(Name = "Description")]
        [Required]
        [StringLength(500)]
        public string Description { get; set; }


        [Display(Name = "Created")]
        [Required]
        public DateTime Created { get; set; }
    }
}
