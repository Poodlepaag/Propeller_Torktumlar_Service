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
        SnurrtumlareDbContext dbContext = new SnurrtumlareDbContext();

        public IEnumerable<Order> Get()
        {
            var listOfOrders = dbContext.Orders.ToList();

            return listOfOrders; 
        }

        public List<Order> Get(User user)
        {
            return dbContext.Orders.Where(c => c.User == user).ToList(); ;
        }
    }
}