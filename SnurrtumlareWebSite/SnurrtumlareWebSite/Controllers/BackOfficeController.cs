using Microsoft.AspNetCore.Mvc;
using SnurrtumlareWebSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Controllers
{
    public class BackOfficeController : Controller
    {
        OrdersService ordersService = new OrdersService();
        ProductsService productsService = new ProductsService();

        public IActionResult Index()
        {
            ViewBag.Admin = 1;
            return View();
        }

        public IActionResult Products()
        {
            var listOfProducts = productsService.GetAllProducts();

            return View(listOfProducts);
        }

        public IActionResult Orders()
        {
            var listOfOrders = ordersService.Get();
            
            return View(listOfOrders);
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }
    }
}
