using CNRBShop.Models;

namespace CNRBShop.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts { get; }
        Product? GetProductById(int productId);
        IEnumerable<Product> GetProductOfTheWeek { get; }


    }
}
