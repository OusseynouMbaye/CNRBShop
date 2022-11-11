using CNRBShop.DbContexts;
using CNRBShop.Models;

namespace CNRBShop.Services
{
    public class CategoryRepository : ICategoryRepository   
    {
        private readonly CNRBShopContext _context;

        public CategoryRepository(CNRBShopContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.OrderBy(product => product.CategoryName);
        }
    }
}
