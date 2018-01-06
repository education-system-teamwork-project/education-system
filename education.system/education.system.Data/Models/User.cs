namespace education.system.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    
    public class User : IdentityUser
    {
        public ICollection<CoursesStudents> EnrolledCourses { get; set; } = new List<CoursesStudents>();

        public ICollection<CoursesLecturers> LecturingCourses { get; set; } = new List<CoursesLecturers>();
    }
}
