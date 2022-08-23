using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductsAdmin;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.UI.Controllers
    {
    //[Route("[controller]")]//url will be admin

    [Route("[controller]")]
    public class AdminController :Controller
        {
        private ApplicationDbContext _ctx;

        public AdminController(ApplicationDbContext ctx)
            {
            _ctx = ctx;
            }
        [HttpGet("products")]//follow by products, this is restful api url format
        public IActionResult GetProducts()
            {
            try { return Ok(new GetProducts(_ctx).Do()); }
            catch
                {
                return BadRequest("Error");
                }
            }
        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id) => Ok(new GetProduct(_ctx).Do(id));

        [HttpPost("products")]
        public async Task< IActionResult> CreateProduct([FromBody] CreateProduct.Request request) { 
            return Ok((await new CreateProduct(_ctx).Do(request)));
            } 

       
        [HttpDelete("products/{id}")]
        public async Task<IActionResult>  DeleteProduct(int id) => Ok((await new DeleteProduct(_ctx).Do(id)));

        [HttpPut("products")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProduct.Request request) => Ok(( await new UpdateProduct(_ctx).Do(request)));

        }

    //[FromBody] needs to be used in json posting

    }
