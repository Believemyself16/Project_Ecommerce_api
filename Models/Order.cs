namespace Project_Ecommerce_api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public float TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingFee { get; set; }
        public string PaymentMethod { get; set; }
    }
}
