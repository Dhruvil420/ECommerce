public class Product
{
    public int Id { get; set; } // Primary Key
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public int Stock { get; set; }

    // Navigation Property
    public ICollection<OrderItem>? OrderItems { get; set; }
}
