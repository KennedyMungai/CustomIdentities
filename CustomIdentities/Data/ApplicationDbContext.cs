using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomIdentities.Data;

public class ApplicationDbContext : IdentityDbContext<EmployeeCharacteristics>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<EmployeeCharacteristics>()
            .Property(u => u.FirstName)
            .HasMaxLength(255);

        modelBuilder.Entity<EmployeeCharacteristics>()
            .Property(u => u.LastName)
            .HasMaxLength(255);

        modelBuilder.Entity<EmployeeCharacteristics>()
            .Property(u => u.PayrollNumber)
            .HasMaxLength(255);

        modelBuilder.Entity<EmployeeCharacteristics>()
            .Property(u => u.Region)
            .HasMaxLength(255);

        modelBuilder.Entity<EmployeeCharacteristics>()
            .Property(u => u.Branch)
            .HasMaxLength(255);

        modelBuilder.Entity<EmployeeCharacteristics>()
            .Property(u => u.DateAndTimeReported);
    }
}

// public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<EmployeeCharacteristics>
// {
//     public void Configure(EntityTypeBuilder<EmployeeCharacteristics> builder)
//     {
//         builder.Property(u => u.FirstName).HasMaxLength(255);
//         builder.Property(u => u.LastName).HasMaxLength(255);
//         builder.Property(u => u.PayrollNumber).HasMaxLength(7);
//         builder.Property(u => u.Region).HasMaxLength(100);
//         builder.Property(u => u.Branch).HasMaxLength(100);
//         builder.Property(u => u.DateAndTimeReported).IsRequired();
//     }
// }