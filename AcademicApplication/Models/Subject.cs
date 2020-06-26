using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicApplication.Models
{
    [Table("Subject")]
    public class Subject
    {
        public Subject()
        {
            Courses = new List<Course>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }

        [Required()]
        [StringLength(50)]
        public string Name { get; set; }

        [Required()]
        public DateTime  Created { get; set; }

        public virtual List<Course> Courses { get; set; }
    }
}
