using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class CartModel
    {
        public List<ProductModel> ProductsInCart { get; set; }
        public bool ContainsItems { get; set; } = false;
    }
}
