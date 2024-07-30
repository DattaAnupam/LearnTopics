namespace RazorPages.Models
{
    public class OrderItem
    {
        public Guid ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
