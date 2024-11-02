namespace ecommerce_api.DOAN_Infrastructure.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public float TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public float ShippingFee { get; set; }
        public string PaymentMethod { get; set; }

        public User User { get; set; }
    }
}
