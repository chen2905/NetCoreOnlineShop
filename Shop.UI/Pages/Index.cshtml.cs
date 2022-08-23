using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.ProductsAdmin;
using Shop.Database;
using System.Collections.Generic;
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
        public CreateProduct.ProductViewModel Product { get; set; }

        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }

        public void OnGet()
            {
            Products = new GetProducts(_ctx).Do();
            }


        //public async Task <IActionResult> OnPost()
        //    {
        //    await new CreateProduct(_ctx).Do(Product);
        //    return RedirectToPage("Index");
        //    }
        }
    }
