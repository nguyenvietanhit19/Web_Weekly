using Microsoft.EntityFrameworkCore;

namespace CF_lab4.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options) { }

        public DbSet<Learner> Learners { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // đặt tên bảng 
            modelBuilder.Entity<Learner>().ToTable("Learner");
            modelBuilder.Entity<Major>().ToTable("Major");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        }
    }
}
