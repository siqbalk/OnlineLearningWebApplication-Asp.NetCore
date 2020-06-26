using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicApplication.Models
{
    [Table("SalesTarget")]
    public class SalesTarget
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesTargetId { get; set; }
                
        [Required]
        public int  CartTarget { get; set; }
        [Required]
        public int OrderTarget { get; set; }
        [Required]
        public int SaleTarget { get; set; }
    }
}
