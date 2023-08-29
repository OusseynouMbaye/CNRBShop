using Bogus;
using CNRBShop.Entities;
using Microsoft.EntityFrameworkCore;

namespace CNRBShop.DbContexts
{
    public class CNRBShopDbContext : DbContext
    {
        public CNRBShopDbContext(DbContextOptions<CNRBShopDbContext> options) : base(options)
        {
        }
        public DbSet<ProductEntities> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ids = 1;
            var product = new Faker<ProductEntities>()
                   .RuleFor(x => x.Id, x => ids++)
                   .RuleFor(x => x.Name, x => x.Commerce.ProductName())
                   .RuleFor(x => x.Price, x => x.Commerce.Price(1).First())
                   .RuleFor(x => x.Image, x => x.Image.PicsumUrl())
                   .RuleFor(x => x.InStock, x => x.Random.Bool())
                   .RuleFor(x => x.Description, x => x.Lorem.Text());

            //modelBuilder.Entity<ProductEntities>().ToTable("Products");
            modelBuilder.Entity<ProductEntities>().HasData(product.GenerateBetween(10, 10));

            base.OnModelCreating(modelBuilder);
        }

    }
}
