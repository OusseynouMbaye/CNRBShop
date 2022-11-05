using CNRBShop.Models;

namespace CNRBShop.Services
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories() => new List<Category>
        {
            new Category{CategoryId=1, CategoryName="chandails", Description="all chandails shop"},
            new Category{CategoryId=2, CategoryName="Paddles", Description="all type of paddle"},
            new Category{CategoryId=3, CategoryName="Kickbords", Description="for quicly kick"},
        };
    }
}
