using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public CustomerModel Customer { get; set; }
        public List<ProductModel> ProductsFromCart { get; set; }
        public decimal TotalOrderCost { get; set; }
        public bool IsDelivered { get; set; } = false;
    }
}
