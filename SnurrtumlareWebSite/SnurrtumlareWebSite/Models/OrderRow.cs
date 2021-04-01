using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class OrderRow
    {
        public DbContext ProductData { get; set; }
        Product product { get; set; }

        decimal ProductPrice { get; set; }

        int Quantity { get; set; }
    }
}
