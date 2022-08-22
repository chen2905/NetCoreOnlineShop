﻿using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.CreateProduct
    {
    public class ProductViewModel
        {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        }
    public  class CreateProducts
        {
        private ApplicationDbContext _context;

        public CreateProducts(ApplicationDbContext context)
            {
            _context = context;
            }

       

        public async Task Do(ProductViewModel vm)
            {
            _context.Products.Add(new Product
                {
        
                Name =vm.Name,
                Description = vm.Description,
                Value = vm.Value
                });

          await _context.SaveChangesAsync();
            }
        }
    }
