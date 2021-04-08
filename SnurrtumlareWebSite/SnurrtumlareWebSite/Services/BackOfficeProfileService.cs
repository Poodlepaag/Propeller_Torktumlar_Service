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

namespace SnurrtumlareWebSite.Services
{
    public class BackOfficeProfileService
    {
        private readonly SnurrtumlareDbContext _context;

        
        public BackOfficeProfileService(SnurrtumlareDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetBackOfficeUserProfile(string userEmail)
        {
            return await _context.Users.Where(u => u.Email == userEmail).ToListAsync();
        }

        public async Task<User> GetBackOfficeUserDetails(int? id)
        {
            return await _context.Users.FirstOrDefaultAsync(m => m.UserId == id);
        }

        public async Task<User> FindBackOfficeUserById(int? id)
        {

            return await _context.Users.FindAsync(id);
        }

        public async Task UpdateBackOfficeUserProfile(User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
        }

        public bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
