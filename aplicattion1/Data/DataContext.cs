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
        public DbSet<DocumentType> DocumentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<CourseType>().HasIndex(d => d.Description).IsUnique();
            modelBuilder.Entity<DocumentType>().HasIndex(ddt => ddt.Description).IsUnique();
            //modelBuilder.Entity<FamousProjects>().HasIndex(f => f.Name).IsUnique();
            //modelBuilder.Entity<Grades>().HasIndex(g => g.Feedback).IsUnique();
            //modelBuilder.Entity<Institute>().HasIndex(I => I.Name_Institute).IsUnique();
            //modelBuilder.Entity<Modality>().HasIndex(M => M.Name).IsUnique();
            //modelBuilder.Entity<Projects>().HasIndex(P => P.Name).IsUnique();
            //modelBuilder.Entity<Role>().HasIndex(R => R.Name).IsUnique();
            //modelBuilder.Entity<User>().HasIndex(u => u.Document).IsUnique();
            //modelBuilder.Entity<UserRole>().HasIndex(ur => ur.Id_User).IsUnique();
        }

        public DbSet<aplicattion1.Data.Entities.DocumentType> DocumentType { get; set; }


    }
}
