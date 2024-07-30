namespace RazorPages.Models
{
    public class Basket
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public int NumberOfItems => Items.Sum(item => item.Quantity);
    }
}
