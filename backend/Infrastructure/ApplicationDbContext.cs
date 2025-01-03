using Microsoft.EntityFrameworkCore;
using Signary.Domain.Entities;

namespace Signary.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<SignDefinition> SignDefinitions { get; set; }
        public DbSet<SignDefinitionReference> SignDefinitionReferences { get; set; }
        public DbSet<SignExpression> SignExpressions { get; set; }
        public DbSet<MouthingOption> MouthingOptions { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SignDefinitionReference>()
                .HasOne(r => r.SourceDefinition)
                .WithMany(def => def.SourceReferences)
                .HasForeignKey(r => r.SourceDefinitionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SignDefinitionReference>()
                .HasOne(r => r.TargetDefinition)
                .WithMany(def => def.TargetReferences)
                .HasForeignKey(r => r.TargetDefinitionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SignDefinition>()
                .HasMany(def => def.Tags)
                .WithMany(tag => tag.Definitions)
                .UsingEntity<Dictionary<string, object>>(
                    "SignDefinitionTag",
                    j => j.HasOne<Tag>().WithMany().HasForeignKey("TagId"),
                    j => j.HasOne<SignDefinition>().WithMany().HasForeignKey("SignDefinitionId"));
        }
    }


}
