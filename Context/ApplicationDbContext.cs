using Microsoft.EntityFrameworkCore;
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
                        .IsRequired()
                        .OnDelete(DeleteBehavior.Cascade);

            //add teacher-role


            //add student-role


            //add admin user
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                Surname = "Admin",
                Password = "Admin",
                Email = "Admin",
                Id_Role = Roles.FirstOrDefault(x => x.isTeacher == true).Id,
                Role = Roles.FirstOrDefault(x => x.isTeacher == true)
            });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

