using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class Cart
    {
        public List<Product> ProductsInCart { get; set; }
        public bool ContainsItems { get; set; } = false;
    }
}
