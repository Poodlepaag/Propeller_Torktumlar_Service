using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using SnurrtumlareWebSite.Services;
using SnurrtumlareWebSite.ViewModels;
using X.PagedList;

namespace SnurrtumlareWebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OrdersController : Controller
    {
        private readonly SnurrtumlareDbContext _context;
        private readonly OrdersService _ordersService;

        public OrdersController(SnurrtumlareDbContext context, OrdersService ordersService)
        {
            _context = context;
            _ordersService = ordersService;
        }

        // GET: Orders
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.OrderIdSortParm = String.IsNullOrEmpty(sortOrder) ? "orderId_desc" : "";
            ViewBag.OrderCostSortParm = String.IsNullOrEmpty(sortOrder) ? "orderCost_desc" : "";
            ViewBag.DeliveryStatusSortParm = String.IsNullOrEmpty(sortOrder) ? "deliveryStatus_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var orders = await _ordersService.GetAllOrders();

            if (!String.IsNullOrEmpty(searchString))
            {
                orders = orders.Where(s => s.OrderId.ToString().Contains(searchString)
                                       || s.TotalOrderCost.ToString().Contains(searchString)).ToList();
            }

            switch (sortOrder)
            {
                case "orderId_desc":
                    orders = orders.OrderByDescending(s => s.OrderId).ToList();
                    break;

                case "orderCost_desc":
                    orders = orders.OrderByDescending(s => s.TotalOrderCost).ToList();
                    break;

                case "deliveryStatus_desc":
                    orders = orders.OrderByDescending(s => s.IsDelivered).ToList();
                    break;

                default:  // Name ascending 
                    orders = orders.OrderBy(s => s.OrderId).ToList();
                    break;
            }


            int pageSize = 5;
            int pageNumber = (page ?? 1);

            ViewBag.OnePageOfOrders = orders.ToPagedList(pageNumber, pageSize);

            return View();
            //return View(await _ordersService.GetAllOrders());
        }


        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order order = await _ordersService.GetOrderDetailsById(id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }

       
        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            OrderViewModel orderViewModel = new();
            {
                orderViewModel.Order = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderRows).ThenInclude(o => o.Product)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            }

            #region OLD
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var order = await _context.Orders.FindAsync(id);

            //if (order == null)
            //{
            //    return NotFound();
            //}

            //ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", order.UserId);
            #endregion

            return View(orderViewModel);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,UserId,TotalOrderCost,IsDelivered")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _ordersService.UpdateOrderDetails(order);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_ordersService.OrderExists(order.OrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", order.UserId);
            return View(order);
        }
        
    }
}
