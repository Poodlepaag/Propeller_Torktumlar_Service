using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Controllers
{
    public class BackOfficeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Orders()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Customers()
        {
            return View();
        }
    }
}
