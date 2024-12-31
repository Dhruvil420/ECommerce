public class OrderItem
{
    public int Id { get; set; } // Primary Key
    public int OrderId { get; set; } // Foreign Key
    public int ProductId { get; set; } // Foreign Key
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    // Navigation Properties
    public Order? Order { get; set; }
    public Product? Product { get; set; }
}
