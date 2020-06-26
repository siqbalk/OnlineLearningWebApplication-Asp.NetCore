using System.Collections.Generic;

namespace AcademicApplication.Areas.Admin.ViewModels
{
    public class AssignRoleListViewModel
    {
        public AssignRoleListViewModel()
        {
            AssignRole = new List<AssignRoleViewModel>();
        }
        public  string AppUserId { get; set; }
        public static string StaticUserId { get; set; }

        public List<AssignRoleViewModel> AssignRole { get; set; }
    }
}
