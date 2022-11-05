using CNRBShop.Models;

namespace CNRBShop.Services
{
    public interface ICategoryRepository
    {
       IEnumerable<Category> GetAllCategories();
    }
}
