namespace ProductApp.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        Repository Category { get; set; } = new Repository();
    }
}
