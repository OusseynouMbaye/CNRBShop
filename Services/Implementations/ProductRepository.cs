using CNRBShop.DbContexts;
using CNRBShop.Entities;
using CNRBShop.Services.Interfaces;

namespace CNRBShop.Services.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly CNRBShopDbContext _context;

        public ProductRepository(CNRBShopDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<ProductEntities> GetProducts()
        {
            return _context.Products.OrderBy(p => p.Id).ToList();
        }
    }
}
