using Microsoft.EntityFrameworkCore;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Services
{
    public class UsersService
    {
        SnurrtumlareDbContext DbContext = new SnurrtumlareDbContext();

        public IEnumerable<User> GetUsers()
        {
            return DbContext.Users.ToList();
        }

        public IEnumerable<User> GetCustomer(int id)
        {
            return DbContext.Users.Where(u => u.UserId == id).ToList();
        }
    }
}
