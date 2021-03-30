using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class StoreViewModel
    {
        public List<ProductModel> AvailableProducts { get; set; }
        public List<CustomerModel> StoreCustomers { get; set; }
        public List<OrderModel> AllOrders { get; set; }
    }
}
