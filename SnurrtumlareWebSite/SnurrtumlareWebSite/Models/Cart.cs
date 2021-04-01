using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class Cart
    {
        public List<OrderRow> ProductsInCart { get; set; }
        public bool ContainsItems { get; set; } = false;
        public decimal TotalCost { get; set; }
    }
}
