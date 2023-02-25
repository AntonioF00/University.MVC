﻿using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using University.MVC.Models;

namespace University.MVC.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<UniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(UniversityContext context) 
        {
            context.Users.AddOrUpdate(x => x.Id,
                                        new User() { Name = "Jane",    Surname = "Austen",  Email = "janeausten@gmail.com",   Nickname = "JaneAus",   Password = "provaJane",    Role = false},
                                        new User() { Name = "Micheal", Surname = "Rossi",   Email = "michealrossi@gmail.com", Nickname = "MichRoss",  Password = "provaMicheal", Role = false },
                                        new User() { Name = "Martin",  Surname = "Verdi",   Email = "martinverdi@gmail.com",  Nickname = "MartiVerd", Password = "provaMartin",  Role = true }
                                        );

            var u = context.Users.FirstOrDefaultAsync(m => m.Email == "martinverdi@gmail.com");

            context.Courses.AddOrUpdate(x => x.Id,
                                        new Course() { Name = "PROGRAMMAZIONE" },
                                        new Course() { Name = "SISTEMI OPERATIVI", },
                                        new Course() { Name = "INGLESE", Id_user = u.Id,  }
                                        );
        }
    }
}
