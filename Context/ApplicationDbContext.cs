using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Reflection.Metadata;
using University.MVC.Models;


namespace University.MVC.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //relations
            //https://learn.microsoft.com/it-it/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key
            modelBuilder.Entity<User>()
                        .HasOne(b => b.Role)
                        .WithMany(i => i.Users)
                        .HasForeignKey(b => b.Id_Role)
                        .HasPrincipalKey(a => a.Id)
                        .IsRequired()
                        .OnDelete(DeleteBehavior.Cascade);

            //add teacher-role
            modelBuilder.Entity<Role>().HasData(new Role()
            {
                Id = Guid.NewGuid(),
                Description = "teacher",
                Users = new()
            });

            //add student-role
            modelBuilder.Entity<Role>().HasData(new Role()
            {
                Id = Guid.NewGuid(),
                Description = "student",
                Users = new()
            });

            //add admin user
            //modelBuilder.Entity<User>().HasData(new User()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Admin",
            //    Surname = "Admin",
            //    Password = "Admin",
            //    Email = "Admin",
            //    Id_Role = modelBuilder.Entity<Role>().ToSqlQuery(new string("SELECT \"Id\"\"\r\n\tFROM public.\"Role\"\r\n\tWHERE \"Description\" = 'teacher';")).,
            //    Role = new()
            //});
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

