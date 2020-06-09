using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class StudentVM
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}