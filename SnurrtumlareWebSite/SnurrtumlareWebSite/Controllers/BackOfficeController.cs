using Microsoft.AspNetCore.Mvc;
using SnurrtumlareWebSite.Services;
using SnurrtumlareWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace SnurrtumlareWebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BackOfficeController : Controller
    {
        readonly OrdersService _ordersService = new();
        readonly ProductsService _productsService = new();
        readonly UsersService _usersService = new();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile(User user)
        {
            return View(user);
        }
               
    }
}
