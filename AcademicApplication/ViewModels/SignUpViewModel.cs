using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.ViewModels
{
    public class SignUpViewModel
    {
        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} must be from {2}  to {1} characters", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} must be from {2}  to {1} characters", MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "{0} must not be excceded from {1}")]
        [EmailAddress(ErrorMessage = "{0} is invalid")]
        public string Email { get; set; }


        [Display(Name = "password")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "{0} must be from {2}  to {1} characters", MinimumLength = 8)]
        public string Password { get; set; }


        [Display(Name = "Confirmpassword")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "{0} must be from {2}  to {1} characters", MinimumLength = 8)]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }

        ////public string ReturnUrl { get; set; }
    }
}
