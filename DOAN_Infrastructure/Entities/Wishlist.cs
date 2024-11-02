namespace ecommerce_api.DOAN_Infrastructure.Entities
{
    public class Wishlist
    {
        public int WishlistId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
