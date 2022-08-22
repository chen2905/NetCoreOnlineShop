﻿using Microsoft.AspNetCore.Mvc;
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


        public async Task <IActionResult> OnPost()
            {

           await new CreateProducts(_ctx).Do(Product.Name, Product.Description, Product.Value);

            return RedirectToPage("Index");
            }
        }
    }
