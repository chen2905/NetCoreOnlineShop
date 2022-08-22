using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

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


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
            {
            _logger = logger;
            }

        public void OnGet()
            {

            }
        }
    }
