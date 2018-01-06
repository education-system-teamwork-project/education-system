namespace education.system.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Lecture
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Lecture name must be between 3 and 50 symbols long.")]
        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public ICollection<CoursesLecturers> Lecturers { get; set; } = new List<CoursesLecturers>();

        public ICollection<Resource> Resources { get; set; } = new List<Resource>();
    }
}
