using Microsoft.AspNetCore.Mvc;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using SnurrtumlareWebSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Controllers
{
    public class CartController : Controller
    {
        private Cart cart { get; set; }
        private CartsService cartsService { get; set; }

        public CartController()
        {
            cartsService = new CartsService();
        }

        public IActionResult Cart()
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            cart = cartsService.GetCart(cart);

            HttpContext.Session.SetObjectAsJson("cart", cart);
            
            return View(cart);
        }

        [HttpPost]
        public IActionResult AddItemToCart(int productId)
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            cart = cartsService.AddItemToCart(cart, productId);

            HttpContext.Session.SetObjectAsJson("cart", cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int productId, int quantity)
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            cart = cartsService.UpdateQuantity(cart, productId, quantity);

            HttpContext.Session.SetObjectAsJson("cart", cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult DeleteItemFromCart(int productId)
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            cart = cartsService.DeleteItemFromCart(cart, productId);

            HttpContext.Session.SetObjectAsJson("cart", cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult ResetCart()
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            cart = cartsService.ClearCart(cart);

            HttpContext.Session.SetObjectAsJson("cart", cart);

            return RedirectToAction(nameof(Cart));
        }
    }
}
