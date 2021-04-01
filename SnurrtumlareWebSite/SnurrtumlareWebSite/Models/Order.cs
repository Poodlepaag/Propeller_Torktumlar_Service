using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public User Customer { get; set; }
        public List<OrderRow> ProductsFromCart { get; set; }
        public decimal TotalOrderCost { get; set; }
        public bool IsDelivered { get; set; } = false;
    }
}
