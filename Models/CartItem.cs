public class CartItem
{
    public int Id { get; set; } // Primary Key
    public int ProductId { get; set; } // Foreign Key
    public int Quantity { get; set; }

    // Navigation Property
    public Product? Product { get; set; }
}
