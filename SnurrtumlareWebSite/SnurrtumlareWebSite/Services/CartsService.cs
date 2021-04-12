using Microsoft.AspNetCore.Http;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Services
{
    public class CartsService
    {
        private readonly SnurrtumlareDbContext DbContext;


        public CartsService(SnurrtumlareDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public Cart GetCart(Cart cart)
        {
            if (cart == null)
            {
                cart = new Cart();
            }

            cart.CartTotalCost = 0;

            foreach (var item in cart.ProductsInCart)
            {
                cart.CartTotalCost += item.ProductPrice * item.Quantity;
            }

            return cart;
        }

        public  Cart AddItemToCart(Cart cart, int productId)
        {
            if (cart == null)
            {
                cart = new Cart();
            }
            foreach (var item in cart.ProductsInCart)
            {
                if (item.ProductId == productId)
                {
                    item.Quantity++;

                    return cart;
                }
            }

            cart.ProductsInCart.Add(DbContext.Products.Single<Product>(p => p.ProductId == productId));
            cart.ContainsItems = true;

            return cart;
        }

        public Cart UpdateQuantity(Cart cart, int productId, int quantity)
        {
            var deleteItem = false;

            foreach (var item in cart.ProductsInCart)
            {
                if (item.ProductId == productId)
                {
                    item.Quantity = quantity;

                    if (item.Quantity <= 0)
                    {
                        deleteItem = true;
                    }
                }
            }

            if (deleteItem == true)
            {
                cart = DeleteItemFromCart(cart, productId);

                deleteItem = false;

                if (cart.ProductsInCart.Count == 0)
                {
                    cart.ContainsItems = false;
                    return cart;
                }
            }

            return cart;
        }

        public Cart DeleteItemFromCart(Cart cart, int productId)
        {
            cart.ProductsInCart.Remove(cart.ProductsInCart.Single<Product>(p => p.ProductId == productId));

            if (cart.ProductsInCart.Count == 0)
            {
                cart.ContainsItems = false;
            }

            return cart;
        }

        public Cart ClearCart(Cart cart)
        {
            cart.ProductsInCart.Clear();

            cart.ContainsItems = false;

            return cart;
        }

        public OrderViewModel CreateOrder(OrderViewModel owm)
        {

            owm.Order = new Order
            {
                IsDelivered = false,
                UserId = owm.User.UserId,
                TotalOrderCost = owm.Cart.CartTotalCost
            };

            foreach (var item in owm.Cart.ProductsInCart)
            {
                OrderRow orderRow = new();

                orderRow.ProductId = item.ProductId;
                orderRow.Quantity = item.Quantity;

                owm.Order.OrderRows.Add(orderRow);
            }

            DbContext.Orders.Add(owm.Order);
            DbContext.SaveChanges();

            return owm;
        }

        public OrderViewModel CheckAndMigrateUser(OrderViewModel owm, string emailToFind)
        {
            owm.User = DbContext.Users.SingleOrDefault(u => u.Email == emailToFind);

            if (owm.User == null)
            {
                owm.User = new User();

                owm.User.Email = emailToFind;

                DbContext.Users.Add(owm.User);
                DbContext.SaveChanges();
            }
            else if (owm.User.Email == null)
            {
                owm.User.Email = emailToFind;

                DbContext.SaveChanges();
            }

            return owm;
        }

        public User UpdateProfile(string userMail, string firstName, string lastName, string phone, string address, string city, string zipcode)
        {
            User user = new();

            user = DbContext.Users.Single(u => u.Email == userMail);
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Phone = phone;
            user.Address = address;
            user.City = city;
            user.ZipCode = zipcode;

            DbContext.Update(user);
            DbContext.SaveChanges();

            return user;
        }

        public User GetUserProfileByEmail(string userEmail)
        {
            return  DbContext.Users.First(u => u.Email == userEmail);
        }
    }



}
