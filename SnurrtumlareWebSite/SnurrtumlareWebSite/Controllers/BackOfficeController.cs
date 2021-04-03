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
        readonly OrdersService _ordersService = new();
        readonly ProductsService _productsService = new();
        readonly UsersService _usersService = new();

        public IActionResult Index()
        {
            ViewBag.Admin = 1;
            return View();
        }

        public IActionResult Products(string searchString)
        {
            return View(_productsService.Get(searchString));
        }

        public IActionResult Orders()
        {
            return View(_ordersService.Get());
        }

        public IActionResult Profile(User user)
        {
            return View(user);
        }

        public IActionResult Users()
        {
            return View(_usersService.GetUsers());
        }
    }
}
