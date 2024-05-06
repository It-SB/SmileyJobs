using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smile.Areas.Identity.Data;

namespace Smile.Data;

public class SmileContext : IdentityDbContext<SmileUser>
{
    public SmileContext(DbContextOptions<SmileContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<SmileUser>
{
    public void Configure(EntityTypeBuilder<SmileUser> builder)
    {
        // Password property configuration
        builder.Property(u => u.Surname)
               .HasMaxLength(50);

        // Name property configuration
        builder.Property(u => u.Name)
               .HasMaxLength(50);

        builder.Property(u => u.Mobile)
               .HasMaxLength(10);

        //builder.Property(u => u.Experience)
        //       .HasMaxLength(30);

        //builder.Property(u => u.TenthGrade).HasDefaultValue(false);

        //// TwelfthGrade property configuration
        //builder.Property(u => u.TwelfthGrade)
        //       .HasDefaultValue(false);

        //// PostGraduation property configuration
        //builder.Property(u => u.PostGraduation)
        //       .HasDefaultValue(false);

        //// PhD property configuration
        builder.Property(u => u.PhD)
               .HasDefaultValue(false);

        //// WorksOn property configuration
        //builder.Property(u => u.CareerField)
        //       .HasMaxLength(50);

        //// Resume property configuration
        //builder.Property(u => u.Resume)
        //       .HasMaxLength(100);

        // Address property configuration
        builder.Property(u => u.Address)
            .HasMaxLength(100);

        // Province property configuration
        //builder.Property(u => u.Province)
        //       .HasMaxLength(50);

        //// Country property configuration
        builder.Property(u => u.Country)
              .HasMaxLength(100);
    }
}
