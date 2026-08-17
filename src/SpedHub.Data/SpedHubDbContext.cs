using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SpedHub.Domain.Entities;

namespace SpedHub.Data;

public partial class SpedHubDbContext : DbContext
{
    public SpedHubDbContext()
    {
    }

    public SpedHubDbContext(DbContextOptions<SpedHubDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accommodation> Accommodations { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Disability> Disabilities { get; set; }

    public virtual DbSet<Goal> Goals { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=SpedHub.DB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accommodation>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Accommodation_Id")
                .IsClustered(false);

            entity.ToTable("Accommodation");

            entity.Property(e => e.Elar).HasDefaultValue(true, "DF_Accommodation_Elar");
            entity.Property(e => e.Math).HasDefaultValue(true, "DF_Accommodation_Math");
            entity.Property(e => e.Science).HasDefaultValue(true, "DF_Accommodation_Science");
            entity.Property(e => e.SocialStudies).HasDefaultValue(true, "DF_Accommodation_SocialStudies");

            entity.HasOne(d => d.Student).WithMany(p => p.Accommodations)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Accommodation_StudentId");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Area_Id")
                .IsClustered(false);

            entity.ToTable("Area");

            entity.HasOne(d => d.Disability).WithMany(p => p.Areas)
                .HasForeignKey(d => d.DisabilityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Area_DisabilityId");
        });

        modelBuilder.Entity<Disability>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Disability_Id")
                .IsClustered(false);

            entity.ToTable("Disability");

            entity.HasOne(d => d.Student).WithMany(p => p.Disabilities)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Disability_StudentId");
        });

        modelBuilder.Entity<Goal>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Goal_Id")
                .IsClustered(false);

            entity.ToTable("Goal");

            entity.Property(e => e.Number).HasColumnType("decimal(2, 1)");

            entity.HasOne(d => d.Student).WithMany(p => p.Goals)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Goal_StudentId");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Service_Id")
                .IsClustered(false);

            entity.ToTable("Service");

            entity.Property(e => e.Frequency).HasMaxLength(1);

            entity.HasOne(d => d.Student).WithMany(p => p.Services)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Service_StudentId");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Student_Id")
                .IsClustered(false);

            entity.ToTable("Student");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Gender).HasMaxLength(1);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
