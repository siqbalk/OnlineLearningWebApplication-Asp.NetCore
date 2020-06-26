using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace AcademicApplication.Models
{
    public  class AppUser :IdentityUser
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }


        public DateTime Created { get; set; }


        public DateTime DateOfBirth { get; set; }


        public byte[] AvatarImage { get; set; }

  

    }
}
