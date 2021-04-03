using Microsoft.EntityFrameworkCore;
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
            var listOfOrders = dbContext.Orders.Include(u => u.User).Include(o => o.OrderRows).ThenInclude(p => p.Product);

            return listOfOrders; 
        }
    }
}