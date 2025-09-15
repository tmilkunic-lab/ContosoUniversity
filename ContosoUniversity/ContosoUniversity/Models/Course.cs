using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [Key] public int CourseId { get; set; }

        [Required, StringLength(80)]
        public string Title { get; set; } = "";

        [Range(0, 6)]
        public int Credits { get; set; }
    }
}
