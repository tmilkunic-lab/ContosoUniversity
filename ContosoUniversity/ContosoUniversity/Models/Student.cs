using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required, StringLength(40)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = "";

        [Required, StringLength(40)]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; } = "";

        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
    }
}
