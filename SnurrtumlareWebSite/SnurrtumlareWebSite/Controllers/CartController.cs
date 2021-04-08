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

        [HttpPost]
        public IActionResult AddItemToCart(int productId)
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            if (cart == null)
            {
                cart = new Cart();
            }
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

        [HttpPost]
        public IActionResult UpdateQuantity(int productId, int quantity)
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            foreach (var item in cart.ProductsInCart)
            {
                if (item.ProductId == productId)
                {
                    item.Quantity = quantity;

                    if (item.Quantity <= 0)
                    {
                        DeleteItemFromCart(productId);

                        if (cart.ProductsInCart.Count == 0)
                        {
                            cart.ContainsItems = false;
                        }
                    }
                }
            }

            HttpContext.Session.SetObjectAsJson("cart", cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult DeleteItemFromCart(int productId)
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            cart.ProductsInCart.Remove(cart.ProductsInCart.Single<Product>(p => p.ProductId == productId));

            if (cart.ProductsInCart.Count == 0)
            {
                cart.ContainsItems = false;
            }

            HttpContext.Session.SetObjectAsJson("cart", cart);

            return RedirectToAction(nameof(Cart));
        }

        [HttpPost]
        public IActionResult ResetCart()
        {
            cart = HttpContext.Session.GetObjectFronJson<Cart>("cart");

            cart.ProductsInCart.Clear();

            cart.ContainsItems = false;

            HttpContext.Session.SetObjectAsJson("cart", cart);

            return RedirectToAction(nameof(Cart));
        }
    }
}
