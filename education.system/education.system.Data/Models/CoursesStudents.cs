namespace education.system.Data.Models
{
    public class CoursesStudents
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string StudentId { get; set; }
        public User Student { get; set; }
    }
}
