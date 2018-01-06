namespace education.system.Data
{
    using education.system.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class EducationSystemDbContext : IdentityDbContext<User>
    {
        public EducationSystemDbContext(DbContextOptions<EducationSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Lecture> Lectures { get; set; }

        public DbSet<CoursesLecturers> CoursesLecturers { get; set; }

        public DbSet<CoursesStudents> CoursesStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>()
                .HasMany(cat => cat.Courses)
                .WithOne(co => co.Category)
                .HasForeignKey(co => co.CategoryId);

            builder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique(true);

            builder.Entity<Course>()
                .HasMany(c => c.Lectures)
                .WithOne(l => l.Course)
                .HasForeignKey(l => l.CourseId);

            builder.Entity<CoursesStudents>()
                .HasOne(cs => cs.Course)
                .WithMany(c => c.Students)
                .HasForeignKey(cs => cs.CourseId);

            builder.Entity<CoursesStudents>()
                .HasOne(cs => cs.Student)
                .WithMany(s => s.EnrolledCourses)
                .HasForeignKey(cs => cs.StudentId);

            builder.Entity<CoursesStudents>()
                .HasKey(cs => new { cs.StudentId, cs.CourseId });

            builder.Entity<CoursesLecturers>()
                .HasOne(cl => cl.Course)
                .WithMany(c => c.Lecturers)
                .HasForeignKey(cl => cl.CourseId);

            builder.Entity<CoursesLecturers>()
                .HasOne(cl => cl.Lecturer)
                .WithMany(l => l.LecturingCourses)
                .HasForeignKey(cl => cl.LecturerId);

            builder.Entity<CoursesLecturers>()
                .HasKey(cl => new { cl.LecturerId, cl.CourseId });

            builder.Entity<Lecture>()
                .HasMany(l => l.Resources)
                .WithOne(r => r.Lecture)
                .HasForeignKey(r => r.LectureId);

            base.OnModelCreating(builder);
        }
    }
}
