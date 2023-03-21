namespace IdentityDemo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

        public List<Order> Orders { get; set; }

    }
}
