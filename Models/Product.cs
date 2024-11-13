namespace Project_Ecommerce_api.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public float Rating { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
