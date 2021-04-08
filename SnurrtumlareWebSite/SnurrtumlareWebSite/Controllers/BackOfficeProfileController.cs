using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using SnurrtumlareWebSite.Services;

namespace SnurrtumlareWebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BackOfficeProfileController : Controller
    {

        private readonly BackOfficeProfileService _backOfficeProfileService;

        public BackOfficeProfileController(BackOfficeProfileService backOfficeProfileService)
        {
            _backOfficeProfileService = backOfficeProfileService;

        }

        // GET: BackOfficeProfile
        public async Task<IActionResult> Index()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            List<User> result = await _backOfficeProfileService.GetBackOfficeUserProfile(userEmail);

            return View(result);
        }

        

        // GET: BackOfficeProfile/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = await _backOfficeProfileService.GetBackOfficeUserDetails(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        #region OLD
        //// GET: BackOfficeProfile/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: BackOfficeProfile/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("UserId,FirstName,LastName,Address,ZipCode,City,Email,Phone")] User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(user);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(user);
        //}
        #endregion

        // GET: BackOfficeProfile/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = await _backOfficeProfileService.FindBackOfficeUserById(id);

            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        

        // POST: BackOfficeProfile/Edit/5
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
                    await _backOfficeProfileService.UpdateBackOfficeUserProfile(user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_backOfficeProfileService.UserExists(user.UserId))
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


        #region OLD
        //// GET: BackOfficeProfile/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var user = await _context.Users
        //        .FirstOrDefaultAsync(m => m.UserId == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(user);
        //}

        //// POST: BackOfficeProfile/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var user = await _context.Users.FindAsync(id);
        //    _context.Users.Remove(user);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}


        //public bool UserExists(int id)
        //{
        //    return _context.Users.Any(e => e.UserId == id);
        //}
        #endregion

    }
}
