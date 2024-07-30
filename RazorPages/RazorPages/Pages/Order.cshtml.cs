using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Contexts;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class OrderModel : PageModel
    {
        private readonly BackeryContext _context;
        public Product Product { get; set; }
        [BindProperty(SupportsGet = true)]
        public Guid ID { get; set; }

        public OrderModel(BackeryContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.FindAsync(ID);
            Console.WriteLine($"Product Name: {Product.ProductName}");
        }
    }
}
