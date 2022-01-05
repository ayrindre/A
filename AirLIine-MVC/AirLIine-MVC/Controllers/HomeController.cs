using System.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AirLIine_MVC.Models;
using Models.Models;
using Microsoft.AspNetCore.Authorization;

namespace AirLIine_MVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly Context _context;
        public static String m;
        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
