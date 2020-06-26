using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Models
{
    [Table("CourseImages")]
    public class CourseImages
    {
        public CourseImages()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseImagesId { get; set; }

        public Course course { get; set; }

        public byte[] CourseImage { get; set; }
    }
}
