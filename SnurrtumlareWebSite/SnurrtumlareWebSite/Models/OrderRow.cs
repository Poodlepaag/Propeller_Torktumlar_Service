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
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal ProductPrice { get; set; }

    }

}
