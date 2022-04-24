using aplicattion1.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace aplicattion1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CourseType>().HasIndex(d => d.Description).IsUnique();
            modelBuilder.Entity<Course>().HasIndex("Name", "CourseTypeId").IsUnique();
          
        }


    }
}
