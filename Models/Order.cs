public class Order
{
    public int Id { get; set; } // Primary Key
    public string UserId { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public decimal TotalAmount { get; set; }

    // Navigation Property
    public ICollection<OrderItem>? OrderItems { get; set; }
}
