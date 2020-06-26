using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AcademicApplication.Models
{
    [Table("Topic")]
   public class Topic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  TopicId { get; set; }

        [Required()]
        [StringLength(50)]
        public string  Name { get; set; }

        [Required()]
        public DateTime Created { get; set; }

        [Required()]
        public Course Course { get; set; }
        [Required()]
        public string  ShortDecription { get; set; }
        [Required()]
        public string  Explanation { get; set; }
    }
}
