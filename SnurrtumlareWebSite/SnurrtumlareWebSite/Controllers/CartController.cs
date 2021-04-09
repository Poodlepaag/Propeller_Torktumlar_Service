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
        private CartsService CartsService { get; set; }
        private OrderViewModel Model { get; set; }

        public CartController()
        {
            CartsService = new CartsService();
            Model = new OrderViewModel();
        }

        [HttpGet]
        public IActionResult Cart()
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            Model.Cart = CartsService.GetCart(Model.Cart);

            HttpContext.Session.SetObjectAsJson("cart", Model.Cart);
            
            return View(Model);
        }

        [HttpPost]
        public IActionResult AddItemToCart(int productId)
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            Model.Cart = CartsService.AddItemToCart(Model.Cart, productId);

            HttpContext.Session.SetObjectAsJson("cart", Model.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int productId, int quantity)
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            Model.Cart = CartsService.UpdateQuantity(Model.Cart, productId, quantity);

            HttpContext.Session.SetObjectAsJson("cart", Model.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult DeleteItemFromCart(int productId)
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            Model.Cart = CartsService.DeleteItemFromCart(Model.Cart, productId);

            HttpContext.Session.SetObjectAsJson("cart", Model.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult ResetCart()
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            Model.Cart = CartsService.ClearCart(Model.Cart);

            HttpContext.Session.SetObjectAsJson("cart", Model.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [Authorize]
        public IActionResult OrderConfirmation()
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            var EmailToFind = User.FindFirstValue(ClaimTypes.Email);

            Model.User = CartsService.DbContext.Users.First(u => u.Email == EmailToFind);

            HttpContext.Session.SetObjectAsJson("order", Model);
            
            return View(Model);
        }

        [Authorize]
        public IActionResult FinalizeOrder()
        {
            Model = HttpContext.Session.GetObjectFronJson<OrderViewModel>("order");

            Model = CartsService.CreateOrder(Model);

            HttpContext.Session.Clear();

            return RedirectToAction(nameof(ModalTransportView));
        }

        public IActionResult ModalTransportView()
        {
            return View();
        }
    }
}
