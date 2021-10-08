using System;
using Course.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Course.Infrastructure.Context
{
    public partial class CourseDbContext : DbContext
    {
        public CourseDbContext()
        {
        }

        public CourseDbContext(DbContextOptions<CourseDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Domain.Entities.Course> Courses { get; set; }
        public virtual DbSet<Educator> Educators { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<LectureProgram> LecturePrograms { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("DataSource=SqliteDb/CourseDb.db;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Course>(entity =>
            {
                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasColumnName("Course_Name");
            });

            modelBuilder.Entity<Educator>(entity =>
            {
                entity.Property(e => e.Gender).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Surname).IsRequired();
            });

            modelBuilder.Entity<Lecture>(entity =>
            {
                entity.Property(e => e.LectureCode)
                    .IsRequired()
                    .HasColumnName("Lecture_Code");

                entity.Property(e => e.LectureName)
                    .IsRequired()
                    .HasColumnName("Lecture_Name");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Lectures)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LectureProgram>(entity =>
            {
                entity.HasOne(d => d.Educator)
                    .WithMany(p => p.LecturePrograms)
                    .HasForeignKey(d => d.EducatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Lecture)
                    .WithMany(p => p.LecturePrograms)
                    .HasForeignKey(d => d.LectureId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Gender).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Surname).IsRequired();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
