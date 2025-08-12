using DeployAzureFree.Server.Model;
using Microsoft.EntityFrameworkCore;

namespace DeployAzureFree.Server
{
    public class AppDbContext : DbContext
    {
        public DbSet<Truck> Trucks { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Truck>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.CreatedDate).HasDefaultValue(DateTime.Now);
            });
        }
    }
}
