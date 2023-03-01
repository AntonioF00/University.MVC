using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Reflection.Metadata;
using University.MVC.Models;


namespace University.MVC.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //relations
            //https://learn.microsoft.com/it-it/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key
            modelBuilder.Entity<User>()
                        .HasOne(b => b.Role)
                        .WithMany(i => i.Users)
                        .HasForeignKey(b => b.Id_Role)
                        .HasPrincipalKey(a => a.Id)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Course>()
                        .HasOne(b => b.User)
                        .WithMany(i => i.Courses)
                        .HasForeignKey(b => b.Id_user)
                        .HasPrincipalKey(a => a.Id)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Role>()
                        .HasMany(b => b.Users)
                        .WithOne(i => i.Role)
                        .HasForeignKey(b => b.Id_Role)
                        .HasPrincipalKey(a => a.Id)
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

            ////add admin user
            //modelBuilder.Entity<User>().HasData(new User()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Admin",
            //    Surname = "Admin",
            //    Password = "Admin",
            //    Email = "Admin",
            //    Id_Role = Roles.FirstOrDefault(p => p.Description.Equals("teacher")).Id,
            //    Role = new()
            //});
        }


    }
}

