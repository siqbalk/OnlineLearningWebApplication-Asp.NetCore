using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.Admin.ViewModels
{
    public class SubjectCreateViewModel
    {
        public SubjectCreateViewModel()
        {

        }

        [Required]
        public string  SubjectName { get; set; }

        [Required]
        public DateTime Created { get; set; }
    }
}
