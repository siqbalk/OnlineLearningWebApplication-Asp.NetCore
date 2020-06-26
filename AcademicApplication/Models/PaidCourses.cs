using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Models
{
    [Table("PaidCourses")]
    public class PaidCourses
    {

        public PaidCourses()
        {

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaidCoursesId { get; set; }


        [Required]
        public Course course { get; set; }


        [Required]
        public int Price { get; set; }

        [Required]
        public AppUser Appuser { get; set; }
    }
}
