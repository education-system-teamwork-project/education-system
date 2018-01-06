namespace education.system.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Course name must be between 3 and 80 symbols long.")]
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Credits { get; set; }

        public bool IsOpen { get; set; }

        public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();

        public ICollection<CoursesStudents> Students { get; set; } = new List<CoursesStudents>();

        public ICollection<CoursesLecturers> Lecturers { get; set; } = new List<CoursesLecturers>();
    }
}
