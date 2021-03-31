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
        DummyData dummyData = new DummyData();

        public List<ProductModel> GetAllProducts()
        {
            return dummyData.TempProducts;
        }

        public List<ProductModel> GetProductsBySearch(string searchString)
        {
            var result = dummyData.TempProducts.Where(p =>
                        p.ProductName.Contains(searchString) ||
                        p.ProductDescription.Contains(searchString) ||
                        p.Category.Contains(searchString));

            return result.ToList();
        }

        public List<ProductModel> GetProductsByCategory(string category)
        {
            return dummyData.TempProducts.Where(p => p.Category == category).ToList();
        }

        public void Add(int productId, string productName, string imageLink, string category, string productDescription, int amountInStock, decimal productPrice)
        {
            ProductModel product = new ProductModel(productId, productName, imageLink, category, productDescription, amountInStock, productPrice);

            dummyData.TempProducts.Add(product);
        }

        public void Delete(ProductModel product)
        {
            dummyData.TempProducts.Remove(product);
        }

        // This can be removed if not needed
        public int GetNumberOfHits(List<ProductModel> result) // Method to get the number of items in a list
        {
            return result.Count();
        }
    }
}
