using CNRBShop.DbContexts;
using CNRBShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CNRBShop.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly CNRBShopContext _context;

        public ProductRepository(CNRBShopContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Product> GetAllProducts
        {
            get
            {
                return _context.Products.Include(c => c.Category);
            }
        }

        public IEnumerable<Product> GetProductOfTheWeek
        {
            get
            {
                return _context.Products.Include(c => c.Category).Where(p => p.IsProductOfTheWeek);
            }
        }

        public Product? GetProductById(int productId)
        {
            return _context.Products.FirstOrDefault(product => product.ProductId == productId);
        }
    }
}
