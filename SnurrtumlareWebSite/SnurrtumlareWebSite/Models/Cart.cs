using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class Cart
    {
        public List<Product> ProductsInCart { get; set; }
        public int RowTotalCost { get; set; } // Quantity * Price
        public bool ContainsItems { get; set; } = false;
        public decimal CartTotalCost { get; set; } // S

        public Cart()
        {
            ProductsInCart = new List<Product>();
        }
    }
}
