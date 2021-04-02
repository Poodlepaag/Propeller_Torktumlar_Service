using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<OrderRow> OrderRows { get; set; }
        public decimal TotalOrderCost { get; set; }
        public bool IsDelivered { get; set; } = false;
    }
}
