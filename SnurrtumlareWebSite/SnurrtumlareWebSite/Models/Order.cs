using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class Order
    {
        public virtual List<OrderRow> OrderRows { get; set; }
        public int OrderId { get; set; }
        public decimal TotalOrderCost { get; set; }
        public bool IsDelivered { get; set; } = false;
        public virtual User User { get; set; }
    }
}
