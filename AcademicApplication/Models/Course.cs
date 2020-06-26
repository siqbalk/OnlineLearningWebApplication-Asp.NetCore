using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicApplication.Models
{
    [Table("Course")]
    public class Course
    {

        public Course()
        {
            topic = new List<Topic>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(1000)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(2500)]
        public string DetailDescription { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public bool IsFeatured { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public Subject Subject { get; set; }

        public List<Topic> topic { get; set; }
        
        [Required]
        public bool  IsPaid { get; set; }

        [Required]
        public CourseStatus  courseStatus { get; set; }

        public string  Image { get; set; }


    }
}
