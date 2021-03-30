using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class StoreViewModel
    {
        public List<Product> AvailableProducts { get; set; }
        public List<Customer> StoreCustomers { get; set; }
        public List<Order> AllOrders { get; set; }
    }
}
