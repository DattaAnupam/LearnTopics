using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages.Pages.Forms
{
    public class AddressFormModel : PageModel
    {
        [BindProperty]
        public Address Address { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // if Index.cshtml.cs contains a property named City, then no need to specify the object name
            // return redirectToPage("/index", new { Address.City }); 
            // would have worked fine
            return RedirectToPage("/index", new { CityName = Address.City });
        }
    }
}
