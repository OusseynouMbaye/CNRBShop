using CNRBShop.Entities;

namespace CNRBShop.Services.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<ProductEntities> GetProducts();
    }
}
