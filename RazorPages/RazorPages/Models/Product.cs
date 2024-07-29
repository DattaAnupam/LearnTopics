namespace RazorPages.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public double Pice { get; set; }
    }
}
