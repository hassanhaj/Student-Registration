using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using StudentRegistration.Web.Entities;

namespace StudentRegistration.Web
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        //    optionsBuilder.UseSqlServer("Server=.;Database=RegistrationDB;integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
