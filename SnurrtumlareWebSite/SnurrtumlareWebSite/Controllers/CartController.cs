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
        SnurrtumlareDbContext snurrtumlareDbContext = new();

        public IActionResult Cart()
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            if (cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetObjectAsJson("cart", cart);
            }
            
            return View(cart);
        }

        public IActionResult AddItemToCart()
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            if (cart == null)
            {
                cart = new Cart();
            }

            var productId = int.Parse(HttpContext.Request.Form["ProductId"]);
            foreach (var item in cart.ProductsInCart)
            {
                if (item.ProductId == productId)
                {
                    item.Quantity++;

                    HttpContext.Session.SetObjectAsJson("cart", cart);

                    return RedirectToAction(nameof(Cart));
                }
            }

            cart.ProductsInCart.Add(snurrtumlareDbContext.Products.Single<Product>(p => p.ProductId == productId));
            cart.ContainsItems = true;

            HttpContext.Session.SetObjectAsJson("cart", cart);

            return RedirectToAction(nameof(Cart));
        }

        public IActionResult ChangeOfQuantity()
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            var newQuantity = int.Parse(HttpContext.Request.Form["Quantity"]);
            var productId = int.Parse(HttpContext.Request.Form["ProductId"]);

            foreach (var item in cart.ProductsInCart)
            {
                if (item.ProductId == productId)
                {
                    item.Quantity = newQuantity;
                }
            }

            HttpContext.Session.SetObjectAsJson("cart", cart);

            return RedirectToAction(nameof(Cart));
        }
    }
}
