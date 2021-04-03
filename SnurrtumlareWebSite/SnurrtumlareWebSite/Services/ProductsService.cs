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
        SnurrtumlareDbContext DbContext = new SnurrtumlareDbContext();

        public List<Product> GetAllProducts()
        {
            return DbContext.Products.ToList();
        }

        public List<Product> GetProductsBySearch(string searchString)
        {
            var result = DbContext.Products.Where(p =>
                        p.ProductName.ToLower().Contains(searchString.ToLower()) ||
                        p.ProductDescription.ToLower().Contains(searchString.ToLower()) ||
                        p.Category.ToLower().Contains(searchString.ToLower()));

            return result.ToList();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return DbContext.Products.Where(p => p.Category == category).ToList();
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

        // This can be removed if not needed
        public int GetNumberOfHits(List<Product> result) // Method to get the number of items in a list
        {
            return result.Count();
        }
    }
}
