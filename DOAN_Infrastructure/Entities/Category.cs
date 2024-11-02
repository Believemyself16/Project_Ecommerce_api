namespace ecommerce_api.DOAN_Infrastructure.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
