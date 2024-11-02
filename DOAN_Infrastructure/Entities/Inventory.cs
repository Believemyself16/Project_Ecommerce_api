namespace ecommerce_api.DOAN_Infrastructure.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int QuantityStock { get; set; }
        public DateTime RestockDate { get; set; }

        public Product Product { get; set; }
    }
}
