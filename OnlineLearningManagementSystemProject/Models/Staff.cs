using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OnlineLearningManagementSystemProject.Models
{
    public class Staff
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Please Enter Your First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Please Enter Your Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(14, MinimumLength = 14, ErrorMessage = "National ID Must Be 14 Numbers")]
        [Required(ErrorMessage = "Please Enter Your National Id")]
        [Display(Name = "National ID")]
        public string NationalID { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        [Display(Name = "Phone Number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]

        public string Email { get; set; }
        [Display(Name = "Picture")]
        public string StaffImage { get; set; }
        public virtual ICollection<StaffCourse> Staffcourses { get; set; }
        public ICollection<Assignment> Assignments { get; set; } // Staff 1 to M Assignment
        public ICollection<Material> Material { get; set; }
    }
}
