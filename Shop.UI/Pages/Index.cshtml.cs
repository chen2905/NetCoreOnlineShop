using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Shop.UI.Pages
    {
    public class IndexModel : PageModel
        {

        public class ProductViewModel
            {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
            }

        [BindProperty]//BindProperty says Product is the main model of the view
        public ProductViewModel Product { get; set; }

        public void OnGet()
            {

            }


        public IActionResult OnPost()
            {
            return RedirectToPage("Index");
            }
        }
    }
