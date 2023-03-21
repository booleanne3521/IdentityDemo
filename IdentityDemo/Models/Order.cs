namespace IdentityDemo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal PriceTotal { get; set; }

        public Customer Customer { get; set; }

    }
}
