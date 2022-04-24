﻿using aplicattion1.Data.Entities;
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
        }

        public DbSet<aplicattion1.Data.Entities.DocumentType> DocumentType { get; set; }


    }
}
