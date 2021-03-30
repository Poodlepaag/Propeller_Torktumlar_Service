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

        public List<OrderModel> Get()

        { 
            return dummyData.TempOrders; 
        }
       
      
public class DummyData
        {
            public DummyData()
            {
            }

            public List<OrderModel> TempOrders { get; internal set; }
        }
    }

   
}
      


