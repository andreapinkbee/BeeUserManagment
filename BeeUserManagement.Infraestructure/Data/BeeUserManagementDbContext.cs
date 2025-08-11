using Microsoft.EntityFrameworkCore;
using BeeUserManagement.Domain.Entities;

namespace BeeUserManagement.Infraestructure.Data
{
    public class BeeUserManagementDbContext : DbContext
    {
        public BeeUserManagementDbContext(DbContextOptions<BeeUserManagementDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aquí mapeas tus tablas si tienen nombres diferentes
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Role>().ToTable("Roles");
        }
    }
}
