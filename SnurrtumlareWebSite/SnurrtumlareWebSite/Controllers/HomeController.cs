using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using SnurrtumlareWebSite.ViewModels;
using SnurrtumlareWebSite.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SnurrtumlareWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductsService _productsService;
        private readonly UsersService _usersService;
        private readonly OrdersService _ordersService;

        public HomeController(ILogger<HomeController> logger,
                              ProductsService productsService,
                              UsersService usersService,
                              OrdersService ordersService)
        {
            _productsService = productsService;
            _ordersService = ordersService;
            _usersService = usersService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products(string searchString)
        {
            return View(_productsService.Get(searchString));
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Career()
        {
            return View();
        }

        public IActionResult CustomerService()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> ProfileView()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            ViewBag.userEmail = userEmail;

            List<User> users = await _usersService.GetUserProfiles(userEmail);


            return View(users);
        }

        [Authorize]
        public IActionResult OrderView()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            ViewBag.userEmail = userEmail;

            var orders = _ordersService.GetAllOrdersByUserEmail(userEmail);

            return View(orders);
        }



        public IActionResult DeliveryTerms()
        {
            return View();
        }

        public IActionResult Faq()
        {
            return View();
        }

        public IActionResult SocialMedia()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
