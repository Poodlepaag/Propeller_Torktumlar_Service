using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ImageLink { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string ProductDescription { get; set; }
        public int AmountInStock { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
