namespace education.system.Data.Models
{
    public class CoursesLecturers
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string LecturerId { get; set; }
        public User Lecturer { get; set; }
    }
}
