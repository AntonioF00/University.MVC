using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using University.MVC.Context;
using University.MVC.Models;

namespace University.MVC.Data.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<University.MVC.Models.UniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(University.MVC.Models.UniversityContext context) 
        {
            context.Users.AddOrUpdate(x => x.Id,
                                        new User() { Name = "Jane Austen" },
                                        new User() { Name = "Charles Dickens" },
                                        new User() { Name = "Miguel de Cervantes" }
                                        );

            context.Courses.AddOrUpdate(x => x.Id,
                                        new Course() { Name = "Jane Austen" },
                                        new Course() { Name = "Charles Dickens" },
                                        new Course() { Name = "Miguel de Cervantes" }
                                        );
        }
    }
}
