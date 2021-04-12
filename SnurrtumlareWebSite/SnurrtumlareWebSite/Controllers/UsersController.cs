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
using X.PagedList;

namespace SnurrtumlareWebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly UsersService _usersService;

        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        // GET: Users
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.UserIdSortParm = String.IsNullOrEmpty(sortOrder) ? "userId_desc" : "";
            ViewBag.FirstNameSortParm = String.IsNullOrEmpty(sortOrder) ? "firstName_desc" : "";
            ViewBag.LastNameSortParm = String.IsNullOrEmpty(sortOrder) ? "lastName_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var users = await _usersService.GetAllUsers();

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => !string.IsNullOrEmpty(s.LastName) && s.LastName.ToLower().Contains(searchString.ToLower())
                                      || !string.IsNullOrEmpty(s.FirstName) && s.FirstName.ToLower().Contains(searchString.ToLower())).ToList();
            }

            switch (sortOrder)
            {
                case "userId_desc":
                    users = users.OrderByDescending(s => s.UserId).ToList();
                    break;

                case "firstName_desc":
                    users = users.OrderByDescending(s => s.FirstName).ToList();
                    break;

                case "lastName_desc":
                    users = users.OrderByDescending(s => s.LastName).ToList();
                    break;

                default:  // Order ascending 
                    users = users.OrderBy(s => s.UserId).ToList();
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            ViewBag.OnePageOfUsers = users.ToPagedList(pageNumber, pageSize);

            return View();
            //return View(await _usersService.GetAllUsers());
        }

        

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = await _usersService.GetUserDetailsById(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,FirstName,LastName,Address,ZipCode,City,Email,Phone")] User user)
        {
            if (ModelState.IsValid)
            {
                await _usersService.AddNewUser(user);

                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = await _usersService.FindUserToEditById(id);

            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,FirstName,LastName,Address,ZipCode,City,Email,Phone")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _usersService.UpdateUserDetails(user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_usersService.UserExists(user.UserId))
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
            return View(user);
        }

        

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = await _usersService.GetUserDetailsById(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _usersService.DeleteUser(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
