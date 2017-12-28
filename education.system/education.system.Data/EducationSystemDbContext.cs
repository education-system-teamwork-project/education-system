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

        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);
        }
    }
}
