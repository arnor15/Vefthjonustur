﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication.Data;

namespace Assignment2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160830163610_ass2database")]
    partial class ass2database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("WebApplication.Models.EntityModels.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseId");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("Semester");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("WebApplication.Models.EntityModels.CourseStudentLinker", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("SSN");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("SSN");

                    b.ToTable("CourseStudentLinkers");
                });

            modelBuilder.Entity("WebApplication.Models.EntityModels.CourseTemplate", b =>
                {
                    b.Property<string>("CourseId");

                    b.Property<string>("Name");

                    b.HasKey("CourseId");

                    b.ToTable("CourseTemplates");
                });

            modelBuilder.Entity("WebApplication.Models.EntityModels.Student", b =>
                {
                    b.Property<string>("SSN");

                    b.Property<string>("Name");

                    b.HasKey("SSN");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WebApplication.Models.EntityModels.CourseStudentLinker", b =>
                {
                    b.HasOne("WebApplication.Models.EntityModels.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication.Models.EntityModels.Student", "Student")
                        .WithMany()
                        .HasForeignKey("SSN");
                });
        }
    }
}
