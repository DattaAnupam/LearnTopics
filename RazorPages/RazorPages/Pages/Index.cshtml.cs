using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Contexts;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BackeryContext _context;
        public List<Product> Products { get; set; } = new();

        public IndexModel(BackeryContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
