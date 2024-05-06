using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Smile.Models.Jobs;

public partial class JobsContext : DbContext
{
    public JobsContext()
    {
    }

    public JobsContext(DbContextOptions<JobsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Job> Jobs { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Data Source=laptop-retuabgb;Initial Catalog=Smile;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Jobs__3214EC079A7D1E5C");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.EducationLevel).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.EmploymentType).HasMaxLength(100);
            entity.Property(e => e.ExperienceLevel).HasMaxLength(100);
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.PostedDate).HasColumnType("datetime");
            entity.Property(e => e.Salary).HasMaxLength(100);
            entity.Property(e => e.Website).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
