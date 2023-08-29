namespace CNRBShop.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public bool InStock { get; set; }
        //public List<string>? Sizes { get; set; } 
        //public List<string>? Colors { get; set; }
        public bool? IsForMan { get; set; }
        public bool? IsFemale { get; set; }
    }
}
