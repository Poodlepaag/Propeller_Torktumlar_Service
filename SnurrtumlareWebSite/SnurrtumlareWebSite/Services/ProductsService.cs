using Microsoft.EntityFrameworkCore;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Services
{
    public class ProductsService
    {
        private readonly SnurrtumlareDbContext _context;

        public ProductsService(SnurrtumlareDbContext context)
        {
            _context = context;
        }

        public List<Product> Get(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
            {
                return _context.Products.ToList();
            }

            var result = _context.Products.Where(p =>
                    p.ProductName.ToLower().Contains(searchString.ToLower()) ||
                    p.ProductDescription.ToLower().Contains(searchString.ToLower()) ||
                    p.Category.ToLower().Contains(searchString.ToLower()));

            return result.ToList();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return _context.Products.Where(p => p.Category == category).ToList();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int? id)
        {
            return await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);
        }

        public async Task AddNewProduct(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> FindProductById(int? id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductById(int id)
        {
            var product = await FindProductById(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }


        public bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

    }
}
