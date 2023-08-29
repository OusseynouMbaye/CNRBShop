using CNRBShop.Services.Interfaces;
using CNRBShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CNRBShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public IActionResult ListProduct()
        {
            ProductListViewModel productListViewModel = new ProductListViewModel(_productRepository.GetProducts());

            return View(productListViewModel);
        }
    }
}
