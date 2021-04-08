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
        public async Task<IActionResult> Index()
        {
            return View(await _ordersService.GetAllOrders());
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
            OrderViewModel orderViewModel = new OrderViewModel();
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
