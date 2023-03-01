﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using University.MVC.Context;

#nullable disable

namespace University.MVC.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("University.MVC.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("FirstDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Id_user")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("SecondDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ThirdDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Id_user");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("University.MVC.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fccdba85-2439-4f54-a103-0f1b03d4227c"),
                            Description = "teacher"
                        },
                        new
                        {
                            Id = new Guid("8a8f69d1-7720-4ee1-adfd-2404c0940dff"),
                            Description = "student"
                        });
                });

            modelBuilder.Entity("University.MVC.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<Guid?>("Id_Role")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Nickname")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id_Role");

                    b.ToTable("User");
                });

            modelBuilder.Entity("University.MVC.Models.Course", b =>
                {
                    b.HasOne("University.MVC.Models.User", "User")
                        .WithMany("Courses")
                        .HasForeignKey("Id_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("University.MVC.Models.User", b =>
                {
                    b.HasOne("University.MVC.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("Id_Role")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Role");
                });

            modelBuilder.Entity("University.MVC.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("University.MVC.Models.User", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
