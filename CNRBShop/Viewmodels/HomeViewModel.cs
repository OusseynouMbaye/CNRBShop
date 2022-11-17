using CNRBShop.Models;

namespace CNRBShop.Viewmodels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOfTheWeek{ get; }
        public HomeViewModel(IEnumerable<Product> productsOfTheWeek)
        {
            ProductsOfTheWeek = productsOfTheWeek ?? throw new ArgumentNullException(nameof(productsOfTheWeek));
        }


    }
}
