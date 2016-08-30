namespace WebApplication.Data {
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using WebApplication.Models.EntityModels;
    using WebApplication.Helpers;

    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseTemplate> CourseTemplates { get; set; }
        public DbSet<CourseStudentLinker> CourseStudentLinkers { get; set; }
    }
}