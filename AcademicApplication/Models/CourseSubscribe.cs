using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Models
{
    [Table("CourseSubscribe")]
    public class CourseSubscribe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseSubscribeId { get; set; }


        [Required]
        public Course course { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public CourseStatus Status { get; set; }

        [Required]
        public AppUser Appuser { get; set; }


    }
}
