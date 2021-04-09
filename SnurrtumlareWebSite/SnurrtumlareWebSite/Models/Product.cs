using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ImageLink { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        [NotMapped]
        public int Quantity { get; set; }

        public Product()
        {
            Quantity = 1;
        }
    }
}
