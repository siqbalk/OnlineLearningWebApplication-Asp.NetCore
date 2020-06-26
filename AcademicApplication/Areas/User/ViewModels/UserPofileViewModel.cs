using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.Areas.User.ViewModels
{
    public class UserPofileViewModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string  Password { get; set; }
        public string  ConfirmaPassword { get; set; }
        public string PhoneNo { get; set; }
        public string Nationality { get; set; }
        public byte[] AvatarImage { get; set; }
        public string role { get; set; }
    }
}
