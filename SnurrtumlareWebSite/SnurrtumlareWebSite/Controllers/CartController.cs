using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using SnurrtumlareWebSite.Services;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Controllers
{
    public class CartController : Controller
    {
        //private Cart cart { get; set; }
        //private User user { get; set; }
        //private Order order { get; set; }
        private CartsService cartsService { get; set; }
        private OrderViewModel owm { get; set; }

        public CartController()
        {
            cartsService = new CartsService();
            owm = new OrderViewModel();
        }

        [HttpGet]
        public IActionResult Cart()
        {
            owm.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            owm.Cart = cartsService.GetCart(owm.Cart);

            HttpContext.Session.SetObjectAsJson("cart", owm.Cart);
            
            return View(owm);
        }

        [HttpPost]
        public IActionResult AddItemToCart(int productId)
        {
            owm.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            owm.Cart = cartsService.AddItemToCart(owm.Cart, productId);

            HttpContext.Session.SetObjectAsJson("cart", owm.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int productId, int quantity)
        {
            owm.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            owm.Cart = cartsService.UpdateQuantity(owm.Cart, productId, quantity);

            HttpContext.Session.SetObjectAsJson("cart", owm.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult DeleteItemFromCart(int productId)
        {
            owm.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            owm.Cart = cartsService.DeleteItemFromCart(owm.Cart, productId);

            HttpContext.Session.SetObjectAsJson("cart", owm.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult ResetCart()
        {
            owm.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            owm.Cart = cartsService.ClearCart(owm.Cart);

            HttpContext.Session.SetObjectAsJson("cart", owm.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [Authorize]
        public IActionResult OrderConfirmation()
        {
            owm.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            var EmailToFind = User.FindFirstValue(ClaimTypes.Email);

            owm.User = cartsService.DbContext.Users.First(u => u.Email == EmailToFind);
            
            return View(owm);
        }

        [Authorize]
        public IActionResult FinalizeOrder()
        {
            owm = cartsService.CreateOrder(owm);

            return View("~/Home/Index");
        }
    }
}
