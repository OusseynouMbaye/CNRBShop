using CNRBShop.Models;

namespace CNRBShop.Viewmodels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string? CurrentCategory { get; set; }

        public ProductListViewModel(IEnumerable<Product> products, string? currentCategory)
        {
            Products = products;
            CurrentCategory = currentCategory;
        }
    }
}
