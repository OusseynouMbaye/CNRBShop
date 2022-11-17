using CNRBShop.Services;
using CNRBShop.Viewmodels;
using Microsoft.AspNetCore.Mvc;

namespace CNRBShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Dry fit man";
            //return View(_productRepository.GetAllProducts);

            ProductListViewModel productListViewModel = new ProductListViewModel
                (_productRepository.GetAllProducts, "chandails");
            return View(productListViewModel);
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}
