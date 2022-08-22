using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.GetProducts
    {
    public class GetProducts
        {
        private ApplicationDbContext _ctx;

        public GetProducts(ApplicationDbContext ctx)
            {
            _ctx = ctx;
            }
        public IEnumerable<ProductViewModel> Do()//raw code said the List is the highest type, IEnumberable is the bare bone 
            {
            return _ctx.Products.ToList().Select(x => new ProductViewModel
                {

                Name = x.Name,
                Description = x.Description,
                Value = $"${x.Value.ToString("N2")}",  // this will convert something  like 1100.50 to 1,100.50

                });
            }
        }


    public class ProductViewModel
        {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        }
    }
