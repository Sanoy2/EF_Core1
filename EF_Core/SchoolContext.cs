﻿using EF_Core.Models;
using EF_Core.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCard> StudentCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(x => x.Id);
            modelBuilder.Entity<Student>().OwnsOne(x => x.PersonalIdNumber).Property(x => x.Value).HasColumnName(nameof(PersonId));
            modelBuilder.Entity<Student>().HasMany(x => x.Cards);
            modelBuilder.Entity<Student>().HasMany(x => x.Participations);

            modelBuilder.Entity<Course>().HasKey(x => x.Id);
            modelBuilder.Entity<Course>().HasMany(x => x.Parcipitations);
            modelBuilder.Entity<Course>().Property(x => x.CourseName);

            modelBuilder.Entity<StudentCard>().HasKey(x => x.Number);
            modelBuilder.Entity<StudentCard>().Property(x => x.Created).HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<CourseParticipation>().HasKey(x => x.Id);
            //modelBuilder.Entity<CourseParticipation>().HasOne(x => x.Student);
            //modelBuilder.Entity<CourseParticipation>().HasOne(x => x.Course);

        }
    }
}
