namespace ProductApp.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public Category Category { get; set; } = new();
    }
}
