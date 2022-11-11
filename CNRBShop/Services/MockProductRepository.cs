using CNRBShop.Models;

namespace CNRBShop.Services
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> GetAllProducts => new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName="Dry fit man",
                    Price= 20.25M,
                    ShortDescription ="Lorem Ipsum",
                    LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    Category = _categoryRepository.GetAllCategories().ToList()[0],
                    ImageUrl="",
                    ImageThumbnailUrl ="images/caramelpopcorncheesecake.jpg",
                    InStock =true,
                    IsProductOfTheWeek=false
                } ,
                new Product
                {
                        ProductId = 2,
                        ProductName="Dry fit woman",
                        Price= 25.25M,
                        ShortDescription ="Lorem Ipsum",
                        LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                        Category = _categoryRepository.GetAllCategories().ToList()[0],
                        ImageUrl="",
                        ImageThumbnailUrl ="images/dry_fit.jpg",
                        InStock =true,
                        IsProductOfTheWeek=false
                } ,
                new Product
                {
                        ProductId = 3,
                        ProductName="Paddles",
                        Price= 15.25M,
                        ShortDescription ="Lorem Ipsum",
                        LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                        Category = _categoryRepository.GetAllCategories().ToList()[1],
                        ImageUrl="",
                        ImageThumbnailUrl ="images/dry_fit.jpg",
                        InStock =true,
                        IsProductOfTheWeek=false
                }
            };

        IEnumerable<Product> IProductRepository.GetProductOfTheWeek => throw new NotImplementedException();

        public Product? GetProductById(int productId)
        {
            return GetAllProducts.FirstOrDefault(product => product.ProductId == productId);
        }

        public IEnumerable<Product> GetProductOfTheWeek
        {
            get{
                return GetAllProducts.Where(product => product.IsProductOfTheWeek);
            }
        }
    }
}
