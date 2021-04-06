using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using SnurrtumlareWebSite.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductsService productsService = new();
        private readonly CartService cartService = new();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products(string searchString)
        {
            return View(productsService.Get(searchString));
        }

        public IActionResult AddItemToCart(Product product)
        {
            //cartService.AddItemToCart(HttpContext.Session.GetString(JsonConvert.SerializeObject(product)))

            return RedirectToAction(nameof(Products));
        }
        public IActionResult DeleteProducts()
        {
            // productsService.Delete();  (Fixar denna vid ett senare tillfälle!)

            return RedirectToAction(nameof(Products));
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Career()
        {
            return View();
        }

        public IActionResult ShoppingCart()
        {
            List<Product> cart = new List<Product>();

            

            return View();
        }

        public IActionResult CustomerService()
        {
            return View();
        }

        public IActionResult ProfileView()
        {
            SnurrtumlareDbContext snurris = new SnurrtumlareDbContext();
            var listOfUser = snurris.Users.ToList();
            return View(listOfUser);
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
