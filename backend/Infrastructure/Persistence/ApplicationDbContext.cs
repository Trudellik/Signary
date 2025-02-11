using Microsoft.EntityFrameworkCore;
using Signary.Domain.Entities;

namespace Signary.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<SignDefinition> SignDefinitions { get; set; }
        public DbSet<SignDefinitionReference> SignDefinitionReferences { get; set; }
        public DbSet<SignExpression> SignExpressions { get; set; }
        public DbSet<MouthingOption> MouthingOptions { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure SignExpression -> SignDefinitions (1-to-many)
            modelBuilder.Entity<SignExpression>()
                .HasMany(se => se.Definitions)
                .WithOne(sd => sd.SignExpression)
                .HasForeignKey(sd => sd.SignExpressionId)
                .OnDelete(DeleteBehavior.Cascade);  // If parent is deleted, delete children

            // Configure SignDefinition -> MouthingOptions (1-to-many)
            modelBuilder.Entity<SignDefinition>()
                .HasMany(sd => sd.Mouthings)
                .WithOne(mo => mo.SignDefinition)
                .HasForeignKey(mo => mo.SignDefinitionId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure SignDefinition <-> Tag (many-to-many)
            modelBuilder.Entity<SignDefinition>()
                .HasMany(sd => sd.Tags)
                .WithMany(t => t.Definitions)
                .UsingEntity<Dictionary<string, object>>(
                    "SignDefinitionTag",
                    j => j.HasOne<Tag>().WithMany().HasForeignKey("TagId"),
                    j => j.HasOne<SignDefinition>().WithMany().HasForeignKey("SignDefinitionId"),
                    j => j.ToTable("SignDefinitionTags")  // Explicit table name
                );

            // Configure SignDefinition self-referencing relationships
            modelBuilder.Entity<SignDefinitionReference>()
                .HasOne(r => r.SourceDefinition)
                .WithMany(sd => sd.SourceReferences)
                .HasForeignKey(r => r.SourceDefinitionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SignDefinitionReference>()
                .HasOne(r => r.TargetDefinition)
                .WithMany(sd => sd.TargetReferences)
                .HasForeignKey(r => r.TargetDefinitionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Additional configurations for better data integrity
            modelBuilder.Entity<Tag>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<SignDefinition>()
                .Property(sd => sd.VideoUrl)
                .HasMaxLength(500);
        }
    }


}
