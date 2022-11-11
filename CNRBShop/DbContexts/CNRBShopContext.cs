using CNRBShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CNRBShop.DbContexts
{
    public class CNRBShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
         
        public CNRBShopContext(DbContextOptions options) : base(options)
        {

        }



    }
}
