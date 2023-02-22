using System;
using Microsoft.EntityFrameworkCore;
using University.MVC.Models;


namespace University.MVC.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
	}
}

