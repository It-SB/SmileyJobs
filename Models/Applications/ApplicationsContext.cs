using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Smile.Models.Applications;

public partial class ApplicationsContext : DbContext
{
    public ApplicationsContext()
    {
    }

    public ApplicationsContext(DbContextOptions<ApplicationsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Application> Applications { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=> optionsBuilder.UseSqlServer("Data Source=laptop-retuabgb;Initial Catalog=Smile;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Applicat__3214EC07BD992F65");

            entity.Property(e => e.ApplicationDate).HasColumnType("datetime");
            entity.Property(e => e.ResumeCv).HasColumnName("ResumeCV");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
