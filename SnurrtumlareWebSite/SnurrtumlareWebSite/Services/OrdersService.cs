using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Services
{
    public class OrdersService
    {
        DummyData dummyData = new DummyData();

        public IEnumerable<Order> Get()
        {
            var listOfOrders = dummyData.TempOrders;

            return listOfOrders; 
        }

        public List<Order> Get(User customer)
        {
            return dummyData.TempOrders.Where(c => c.Customer == customer).ToList(); ;
        }
    }
}
      


