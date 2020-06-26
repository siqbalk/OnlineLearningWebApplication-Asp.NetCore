using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
namespace AcademicApplication.Models
{
    public   class AppRole : IdentityRole
    {
        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime Created { get; set; }
    }
}
