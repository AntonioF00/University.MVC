using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace University.MVC.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("name=UniversityContext")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public System.Data.Entity.DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<Course> Courses { get; set; }

    }
}
