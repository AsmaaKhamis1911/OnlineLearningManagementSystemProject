﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OnlineLearningManagementSystemProject.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

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

        [Required(ErrorMessage = "Please Enter Your University ID")]
        [Display(Name = "University ID")]
        public string UniversityID { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        [Display(Name = "Phone Number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Enrollment Year")]
        [Display(Name = "Enrollment Year")]
        public int EnrollYear { get; set; }

        [Display(Name = "Picture")]
        public string StudentPicture { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<StudentFile> StudentFiles { get; set; } // Student 1 to M StudentFiles
    }
}
