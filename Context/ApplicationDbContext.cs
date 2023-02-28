using Microsoft.EntityFrameworkCore;
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



            //add admin user
            modelBuilder.Entity<User>().HasData(new User() { 
                                                             Id = Guid.NewGuid(), 
                                                             Name = "Admin", 
                                                             Surname = "Admin", 
                                                             Password = "Admin", 
                                                             Email = "Admin", 
                                                             Role = true 
                                                            });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

