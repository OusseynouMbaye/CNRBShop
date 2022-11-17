using CNRBShop.Services;
using CNRBShop.Viewmodels;
using Microsoft.AspNetCore.Mvc;

namespace CNRBShop.Controllers
{
    public class HomeController : Controller
    {
        public readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public IActionResult Index()
        {
            var productOfWeek = _productRepository.GetProductOfTheWeek;
            var homeViewModel = new HomeViewModel(productOfWeek);

            return View(homeViewModel);
        }
    }
}
