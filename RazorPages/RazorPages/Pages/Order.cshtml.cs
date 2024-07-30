using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Contexts;
using RazorPages.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace RazorPages.Pages
{
    public class OrderModel : PageModel
    {
        #region Class veriables
        private readonly BackeryContext _context;
        public Product Product { get; set; }
        [BindProperty(SupportsGet = true)]
        public Guid ID { get; set; }
        [BindProperty, Range(1, int.MaxValue, ErrorMessage = "You must order at least one item")]
        public int Quantity { get; set; } = 1;
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
                Basket basket = new();
                if (Request.Cookies[nameof(Basket)] is not null)
                {
                    basket = JsonSerializer.Deserialize<Basket>(Request.Cookies[nameof(Basket)]);
                }

                basket.Items.Add(
                    new OrderItem()
                    {
                        ProductID = ID,
                        Quantity = Quantity,
                        UnitPrice = Price
                    }
                );

                var json = JsonSerializer.Serialize(basket);
                var cookiesOptions = new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(30),
                };
                Response.Cookies.Append(nameof(Basket), json, cookiesOptions);

                return RedirectToPage("/Index");

                //Confirmation = $@"You have ordered {Quantity} x {Product.ProductName}
                //                at a total cost of {Quantity * Product.Price:c}";
                //return RedirectToPage("/OrderSuccess");
            }

            return Page();
        }
    }
}
