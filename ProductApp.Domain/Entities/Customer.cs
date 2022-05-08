namespace ProductApp.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? PhonNumber { get; set; }
        List<Order> Orders { get; set; } = new List<Order>();
    }
}
