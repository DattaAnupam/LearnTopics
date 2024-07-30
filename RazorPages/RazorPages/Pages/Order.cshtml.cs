using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Contexts;
using RazorPages.Models;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace RazorPages.Pages
{
    public class OrderModel : PageModel
    {
        #region Class veriables
        private readonly BackeryContext _context;
        public Product Product { get; set; }
        [BindProperty(SupportsGet = true)]
        public Guid ID { get; set; }
        [BindProperty, Range(1, int.MaxValue, ErrorMessage = "You must order at lease one item")]
        public int Quantity { get; set; } = 1;
        [BindProperty, Required, EmailAddress(ErrorMessage = "Please Enter a valid Email Address"), Display(Name = "Your Email Address")]
        public string OrderEmail { get; set; }
        [BindProperty, Required, Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; }
        [BindProperty]
        public decimal Price { get; set; }
        [TempData]
        public string Confirmation { get; set; }
        #endregion

        public OrderModel(BackeryContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.FindAsync(ID);
            Console.WriteLine($"Product Name: {Product.ProductName}");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Product = await _context.Products.FindAsync(ID);
            if (ModelState.IsValid)
            {
                Confirmation = $@"You have ordered {Quantity} x {Product.ProductName}
                                at a total cost of {Quantity * Product.Price:c}";
                return RedirectToPage("/OrderSuccess");
            }
            return Page();
        }
    }
}
