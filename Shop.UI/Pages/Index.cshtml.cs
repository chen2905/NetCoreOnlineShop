using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
using Shop.Database;
using System.Threading.Tasks;

namespace Shop.UI.Pages
    {
    public class IndexModel : PageModel
        {
        private ApplicationDbContext _ctx;

        public IndexModel(ApplicationDbContext ctx)
            {
            _ctx = ctx;
            }

     
        [BindProperty]//BindProperty says Product is the main model of the view
        public ProductViewModel Product { get; set; }

        public void OnGet()
            {

            }


        public async Task <IActionResult> OnPost()
            {
            await new CreateProducts(_ctx).Do(Product);
            return RedirectToPage("Index");
            }
        }
    }
