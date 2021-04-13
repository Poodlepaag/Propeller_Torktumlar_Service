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
        private readonly CartsService cartsService;
        private OrderViewModel Model;


        public CartController(CartsService cartsService, OrderViewModel orderViewModel)
        {
            this.cartsService = cartsService;
            Model = orderViewModel;
        }

        [HttpGet]
        public IActionResult Cart()
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            Model.Cart = cartsService.GetCart(Model.Cart);

            HttpContext.Session.SetObjectAsJson("cart", Model.Cart);

            return View(Model);
        }

        [HttpPost]
        public IActionResult AddItemToCart(int productId)
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            Model.Cart = cartsService.AddItemToCart(Model.Cart, productId);

            HttpContext.Session.SetObjectAsJson("cart", Model.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int productId, int quantity)
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            Model.Cart = cartsService.UpdateQuantity(Model.Cart, productId, quantity);

            HttpContext.Session.SetObjectAsJson("cart", Model.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult DeleteItemFromCart(int productId)
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            Model.Cart = cartsService.DeleteItemFromCart(Model.Cart, productId);

            HttpContext.Session.SetObjectAsJson("cart", Model.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult ResetCart()
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            Model.Cart = cartsService.ClearCart(Model.Cart);

            HttpContext.Session.SetObjectAsJson("cart", Model.Cart);

            return RedirectToAction(nameof(Cart));
        }

        [Authorize]
        public IActionResult OrderConfirmation()
        {
            Model.Cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            var EmailToFind = User.FindFirstValue(ClaimTypes.Email);

            cartsService.CheckAndMigrateUser(Model, EmailToFind);

            Model.User = cartsService.GetUserProfileByEmail(EmailToFind);

            HttpContext.Session.SetObjectAsJson("order", Model);

            return View(Model);
        }

        [Authorize]
        public IActionResult FinalizeOrder()
        {
            Model = HttpContext.Session.GetObjectFronJson<OrderViewModel>("order");

            Model = cartsService.CreateOrder(Model);

            HttpContext.Session.Clear();

            return RedirectToAction(nameof(ModalTransportView));
        }

        public IActionResult ModalTransportView()
        {
            return View();
        }

        public IActionResult UpdateProfile(string firstName, string lastName, string phone, string address, string city, string zipcode)
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Model = HttpContext.Session.GetObjectFronJson<OrderViewModel>("order");

            Model.User = cartsService.UpdateProfile(userEmail, firstName, lastName, phone, address, city, zipcode);

            HttpContext.Session.SetObjectAsJson("order", Model);

            return RedirectToAction(nameof(OrderConfirmation));
        }
    }
}
