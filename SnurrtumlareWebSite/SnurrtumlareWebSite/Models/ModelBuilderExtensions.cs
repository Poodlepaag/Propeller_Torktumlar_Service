using Microsoft.EntityFrameworkCore;
using SnurrtumlareWebSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order() { OrderId = 123456, UserId = 1, IsDelivered = false, TotalOrderCost = 999},
                new Order() { OrderId = 234567, UserId = 2, IsDelivered = true, TotalOrderCost = 4995});

            modelBuilder.Entity<OrderRow>().HasData(
                new List<OrderRow>() {
                    new OrderRow() { OrderRowId = 12, OrderId = 123456, ProductId = 1, Quantity = 1},
                    new OrderRow() { OrderRowId = 13, OrderId = 123456, ProductId = 2, Quantity = 2},
                    new OrderRow() { OrderRowId = 14, OrderId = 234567, ProductId = 3, Quantity = 1},
                    new OrderRow() { OrderRowId = 15, OrderId = 234567, ProductId = 4, Quantity = 1}
                });

            modelBuilder.Entity<User>().HasData(
                new User() { UserId = 1, FirstName = "Abdi", LastName = "Benådsson", Address = "Himlastråket 666", ZipCode = "12345", City = "Himmelriket", Email = "send_me_your_prayers@abdi.com", Phone = "0704563212" },
                new User() { UserId = 2, FirstName = "Cecilia", LastName = "Lind", Address = "Sillstigen 12", ZipCode = "65225", City = "Karlstad", Email = "lind.cecilia@coldmail.com", Phone = "0736545285" },
                new User() { UserId = 3, FirstName = "Darko", LastName = "Petrovic", Address = "Gnejsvägen 45", ZipCode = "84070", City = "Hammarstrand", Email = "darko.petrovic@gomail.com", Phone = "0726547894" },
                new User() { UserId = 4, FirstName = "Märta", LastName = "Ljunquist", Address = "Nobelvägen 62", ZipCode = "21215", City = "Malmö", Email = "marljung@yahoo.it", Phone = "040979797" },
                new User() { UserId = 5, FirstName = "Robert", LastName = "Fayer", Address = "Smultronstråket 11", ZipCode = "12323", City = "Farsta", Email = "robbyfire@msm.com", Phone = "0762316497" },
                new User() { UserId = 6, FirstName = "Janina", LastName = "Müller", Address = "Forskningsvägen 2", ZipCode = "90638", City = "Umeå", Email = "janinamuller@ichbin.de", Phone = "0702026978" },
                new User() { UserId = 7, FirstName = "Pedro", LastName = "Velasquez", Address = "Gesslegatan 70", ZipCode = "30261", City = "Halmstad", Email = "pedro_velasquez@hotmail.se", Phone = "0736974121" },
                new User() { UserId = 8, FirstName = "Amina", LastName = "Asghar", Address = "Polartorget 2", ZipCode = "59791", City = "Åtvidaberg", Email = "amiina_asghar_84@yahoo.se", Phone = "0704563289" },
                new User() { UserId = 9, FirstName = "Uno", LastName = "Svenningsson", Address = "Marsipanvägen 45", ZipCode = "35258", City = "Växjö", Email = "unouno@saltsill.com", Phone = "0729875214" },
                new User() { UserId = 10, FirstName = "Juha", LastName = "Määki", Address = "Trälgatan 102", ZipCode = "70510", City = "Örebro", Email = "juha_1337@suomisoundi.fi", Phone = "0768521498" },
                new User() { UserId = 11, FirstName = "Anders", LastName = "Persson", Address = "Rödmålavägen 7", ZipCode = "22242", City = "Lund", Email = "anderspersson52@irra.se", Phone = "0701238545" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 1, ProductName = "Propellerkeps Deluxe", ImageLink = "/assets/pictures/Kepsar/Prop1.png", Category = "Keps", ProductDescription = "Kepsarnas keps", ProductPrice = 189 },
                new Product() { ProductId = 2, ProductName = "Propellerkeps Premium", ImageLink = "/assets/pictures/Kepsar/Prop10.png", Category = "Keps", ProductDescription = "Keps med guldskärm", ProductPrice = 179 },
                new Product() { ProductId = 3, ProductName = "Torktumlare X3", ImageLink = "/assets/pictures/Torktumlare/Tork1.png", Category = "Torktumlare", ProductDescription = "Instegsmodell bland torktumlare", ProductPrice = 4990 },
                new Product() { ProductId = 4, ProductName = "Torktumlare XT55", ImageLink = "/assets/pictures/Torktumlare/Tork10.png", Category = "Torktumlare", ProductDescription = "Premium Torktumlare med det lilla extra", ProductPrice = 7990 },
                new Product() { ProductId = 5, ProductName = "Propellerkeps Crazy", ImageLink = "/assets/pictures/Kepsar/Prop11.png", Category = "Keps", ProductDescription = "Propellerkepsen för den som testar gränser", ProductPrice = 149 }
                );

        }
    }
}
