namespace ProductApp.Domain.Entities
{
    public class Repository
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        List<Product> Products { get; set; } = new List<Product>();
    }
}
