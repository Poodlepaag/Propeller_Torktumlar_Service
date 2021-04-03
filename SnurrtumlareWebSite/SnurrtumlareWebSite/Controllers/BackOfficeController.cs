using Microsoft.AspNetCore.Mvc;
using SnurrtumlareWebSite.Services;
using SnurrtumlareWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Controllers
{
    public class BackOfficeController : Controller
    {
        OrdersService _ordersService = new OrdersService();
        ProductsService _productsService = new ProductsService();
        UsersService _usersService = new UsersService();

        public IActionResult Index()
        {
            ViewBag.Admin = 1;
            return View();
        }

        public IActionResult Products()
        {
            var listOfProducts = _productsService.GetAllProducts();

            return View(listOfProducts);
        }

        public IActionResult Orders()
        {
            var listOfOrders = _ordersService.Get();
            
            return View(listOfOrders);
        }

        public IActionResult Profile(User user)
        {
            return View(user);
        }

        public IActionResult Users()
        {
            var listOfCustomers = _usersService.GetUsers();

            return View(listOfCustomers);
        }
    }
}
