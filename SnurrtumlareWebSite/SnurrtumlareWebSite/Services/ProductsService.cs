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

        //public void Add(int productId, string productName, string imageLink, string category, string productDescription, int amountInStock, decimal productPrice)
        //{
        //    Product product = new Product(productId, productName, imageLink, category, productDescription, amountInStock, productPrice);

        //    dummyData.TempProducts.Add(product);
        //}

        //public void Delete(Product product)
        //{
        //    dummyData.TempProducts.Remove(product);
        //}
    }
}
