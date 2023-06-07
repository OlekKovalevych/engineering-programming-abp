using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LAB.Authorization.Roles;
using LAB.Authorization.Users;
using LAB.MultiTenancy;
using LAB.Cars;
using LAB.Categories;
using LAB.Products;

namespace LAB.EntityFrameworkCore
{
    public class LABDbContext : AbpZeroDbContext<Tenant, Role, User, LABDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public LABDbContext(DbContextOptions<LABDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasOne(c => c.User)
                .WithOne()
                .HasForeignKey<Category>(c => c.UserId);
        }
    }
}
