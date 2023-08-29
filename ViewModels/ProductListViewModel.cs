using CNRBShop.Entities;

namespace CNRBShop.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<ProductEntities> Products { get;  }

        public ProductListViewModel(IEnumerable<ProductEntities> products)
        {
            Products = products ?? throw new ArgumentNullException(nameof(products));
        }
    }
}
