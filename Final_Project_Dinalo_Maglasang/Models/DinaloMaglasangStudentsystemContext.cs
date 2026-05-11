using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_Dinalo_Maglasang.Models;

public partial class DinaloMaglasangStudentsystemContext : DbContext
{
    public DinaloMaglasangStudentsystemContext()
    {
    }

    public DinaloMaglasangStudentsystemContext(DbContextOptions<DinaloMaglasangStudentsystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;database=dinalo_maglasang_studentsystem;user=root;password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("PRIMARY");

            entity.ToTable("enrollments");

            entity.HasIndex(e => e.InstructorId, "fk_enrollments_instructors");

            entity.HasIndex(e => e.ScheduleId, "fk_enrollments_schedules");

            entity.HasIndex(e => e.StudentId, "fk_enrollments_students");

            entity.Property(e => e.EnrollmentId).HasColumnName("enrollment_id");
            entity.Property(e => e.DateEnrolled)
                .HasColumnType("date")
                .HasColumnName("date_enrolled");
            entity.Property(e => e.InstructorId).HasColumnName("instructor_id");
            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.StudentId).HasColumnName("student_id");

            entity.HasOne(d => d.Instructor).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.InstructorId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_enrollments_instructors");

            entity.HasOne(d => d.Schedule).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.ScheduleId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_enrollments_schedules");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_enrollments_students");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.GradeId).HasName("PRIMARY");

            entity.ToTable("grades");

            entity.HasIndex(e => e.SubjectId, "fk_grades_subjects");

            entity.Property(e => e.GradeId).HasColumnName("grade_id");
            entity.Property(e => e.GradeValue)
                .HasPrecision(5)
                .HasColumnName("grade_value");
            entity.Property(e => e.Remark)
                .HasMaxLength(20)
                .HasColumnName("remark");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");

            entity.HasOne(d => d.Subject).WithMany(p => p.Grades)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_grades_subjects");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InstructorId).HasName("PRIMARY");

            entity.ToTable("instructors");

            entity.Property(e => e.InstructorId).HasColumnName("instructor_id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("middle_name");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PRIMARY");

            entity.ToTable("schedules");

            entity.HasIndex(e => e.InstructorId, "fk_schedules_instructors");

            entity.HasIndex(e => e.SubjectId, "fk_schedules_subjects");

            entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");
            entity.Property(e => e.DayGroup)
                .HasMaxLength(3)
                .HasColumnName("day_group");
            entity.Property(e => e.EndTime)
                .HasColumnType("time")
                .HasColumnName("end_time");
            entity.Property(e => e.InstructorId).HasColumnName("instructor_id");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.TimeStart)
                .HasColumnType("time")
                .HasColumnName("time_start");

            entity.HasOne(d => d.Instructor).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.InstructorId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_schedules_instructors");

            entity.HasOne(d => d.Subject).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_schedules_subjects");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PRIMARY");

            entity.ToTable("students");

            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Course)
                .HasMaxLength(50)
                .HasColumnName("course");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("middle_name");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PRIMARY");

            entity.ToTable("subjects");

            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.CourseCode)
                .HasMaxLength(20)
                .HasColumnName("course_code");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(100)
                .HasColumnName("subject_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
