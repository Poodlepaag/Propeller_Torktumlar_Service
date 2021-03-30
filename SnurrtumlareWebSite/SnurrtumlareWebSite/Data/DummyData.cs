using SnurrtumlareWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Data
{
    public class DummyData
    {
        public List<CustomerModel> TempCustomers { get; set; }

        public List<ProductModel> TempProducts { get; set; }

        public List<OrderModel> TempOrders { get; set; }
        public List<AdminUserModel> TempAdmins { get; set; }
        public CartModel TempCart { get; set; }

        public DummyData()
        {
            TempCustomers = new List<CustomerModel>
            {
                new CustomerModel() {CustomerId = 1, FirstName = "Anders", LastName = "Persson", Address = "Rödmålavägen 7", ZipCode = "22242", City = "Lund", Email = "anderspersson52@irra.se", Phone = "0701238545"},
                new CustomerModel() {CustomerId = 2, FirstName = "Cecilia", LastName = "Lind", Address = "Sillstigen 12", ZipCode = "65225", City = "Karlstad", Email = "lind.cecilia@coldmail.com", Phone = "0736545285"},
                new CustomerModel() {CustomerId = 3, FirstName = "Darko", LastName = "Petrovic", Address = "Gnejsvägen 45", ZipCode = "84070", City = "Hammarstrand", Email = "darko.petrovic@gomail.com", Phone = "0726547894"},
                new CustomerModel() {CustomerId = 4, FirstName = "Märta", LastName = "Ljunquist", Address = "Nobelvägen 62", ZipCode = "21215", City = "Malmö", Email = "marljung@yahoo.it", Phone = "040979797"},
                new CustomerModel() {CustomerId = 5, FirstName = "Robert", LastName = "Fayer", Address = "Smultronstråket 11", ZipCode = "12323", City = "Farsta", Email = "robbyfire@msm.com", Phone = "0762316497"},
                new CustomerModel() {CustomerId = 6, FirstName = "Janina", LastName = "Müller", Address = "Forskningsvägen 2", ZipCode = "90638", City = "Umeå", Email = "janinamuller@ichbin.de", Phone = "0702026978"},
                new CustomerModel() {CustomerId = 7, FirstName = "Pedro", LastName = "Velasquez", Address = "Gesslegatan 70", ZipCode = "30261", City = "Halmstad", Email = "pedro_velasquez@hotmail.se", Phone = "0736974121"},
                new CustomerModel() {CustomerId = 8, FirstName = "Amina", LastName = "Asghar", Address = "Polartorget 2", ZipCode = "59791", City = "Åtvidaberg", Email = "amiina_asghar_84@yahoo.se", Phone = "0704563289"},
                new CustomerModel() {CustomerId = 9, FirstName = "Uno", LastName = "Svenningsson", Address = "Marsipanvägen 45", ZipCode = "35258", City = "Växjö", Email = "unouno@saltsill.com", Phone = "0729875214"},
                new CustomerModel() {CustomerId = 10, FirstName = "Juha", LastName = "Määki", Address = "Trälgatan 102", ZipCode = "70510", City = "Örebro", Email = "juha_1337@suomisoundi.fi", Phone = "0768521498"},
                new CustomerModel() {CustomerId = 11, FirstName = "Abdi", LastName = "Benådsson", Address = "Himlastråket 666", ZipCode = "12345", City = "Himmelriket", Email = "send_me_your_prayers@abdi.com", Phone = "0704563212"},

            };

            TempProducts = new List<ProductModel>
            {
            new ProductModel("Propellerkeps Deluxe", "/assets/pictures/Kepsar/Prop1.png", "Keps", "Kepsarnas keps", 25, 189),
            new ProductModel("Propellerkeps Premium", "/assets/pictures/Kepsar/Prop10.png", "Keps", "Keps med guldskärm", 10, 179),
            new ProductModel("Torktumlare X3", "/assets/pictures/Torktumlare/Tork1.png", "Torktumlare", "Instegsmodell bland torktumlare", 5, 4990),
            new ProductModel("Torktumlare XT55", "/assets/pictures/Torktumlare/Tork10.png", "Torktumlare", "Premium Torktumlare med det lilla extra", 2, 7990),
            new ProductModel("Propellerkeps Crazy", "/assets/pictures/Kepsar/Prop11.png", "Keps", "Propellerkepsen för den som testar gränser", 5, 149)
            };

            TempCart = new CartModel
            {
                ContainsItems = true,
                ProductsInCart = TempProducts
            };

            TempOrders = new List<OrderModel>
            {
                new OrderModel() {OrderId = 1, Customer = TempCustomers[0], IsDelivered = false, ProductsFromCart = TempCart.ProductsInCart, TotalOrderCost = 500},
                new OrderModel() {OrderId = 2, Customer = TempCustomers[5], IsDelivered = false, ProductsFromCart = TempCart.ProductsInCart, TotalOrderCost = 650},
                new OrderModel() {OrderId = 3, Customer = TempCustomers[5], IsDelivered = true, ProductsFromCart = TempCart.ProductsInCart, TotalOrderCost = 800},
                new OrderModel() {OrderId = 4, Customer = TempCustomers[1], IsDelivered = true, ProductsFromCart = TempCart.ProductsInCart, TotalOrderCost = 700},
                new OrderModel() {OrderId = 5, Customer = TempCustomers[10], IsDelivered = true, ProductsFromCart = TempCart.ProductsInCart, TotalOrderCost = 100}
            };

            TempAdmins = new List<AdminUserModel>
            {
            new AdminUserModel() {UserName = "Fredrik", Password = "Admin1!"},
            new AdminUserModel() {UserName = "Christian", Password = "Admin2!"}
            };

        }

    }
}
