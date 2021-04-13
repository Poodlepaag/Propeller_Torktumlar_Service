using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public User User { get; set; }
        public List<OrderRow> OrderRows { get; set; }
        public Cart Cart { get; set; }
    }
}
