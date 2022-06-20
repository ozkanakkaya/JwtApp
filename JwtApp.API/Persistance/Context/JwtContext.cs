using JwtApp.API.Core.Domain;
using JwtApp.API.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace JwtApp.API.Persistance.Context
{
    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options) : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();

        public DbSet<Category> Categories => Set<Category>();

        public DbSet<AppUser> AppUsers => Set<AppUser>();

        public DbSet<AppRole> AppRoles => Set<AppRole>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());

            base.OnModelCreating(modelBuilder); 
        }
    }
}
