namespace FitnessTrackerAPI.Data
{
    using Microsoft.EntityFrameworkCore;
    using FitnessTrackerAPI.Models; // Add this if you need to reference models within the same namespace

    public class FitnessContext : DbContext
    {
        public FitnessContext(DbContextOptions<FitnessContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        // Define other DbSets here

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Username).HasMaxLength(100).HasColumnType("varchar");
            entity.Property(e => e.Email).HasMaxLength(100).HasColumnType("varchar");
            entity.Property(e => e.Phone).HasMaxLength(15).HasColumnType("varchar");
            entity.Property(e => e.Password).HasMaxLength(255).HasColumnType("varchar");
        });
    }
    }
}
