using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using AirLIine_MVC.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
//using AirLIine-MVC.Models;

namespace AirLIine_MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context _context;

        public LoginController(Context Context)
        {
            _context = Context;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Phone()
        {

            return View();
        }
        public IActionResult Pass(UserViewModel user)
        {
            if (_context.TblUsers.Any(b => b.Phone == user.Phone))
            {
                HttpContext.Session.SetString("PhoneS", user.Phone);
                return View();
            }
            else
            {
                return View("Add");
            }

        }
        public IActionResult CodSms()
        {
            return View();
        }
        public IActionResult exit()
        {
            HttpContext.Session.Remove("PhoneS");
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Phone");

        }
        public IActionResult check(UserViewModel user)
        {
            var Q = _context.TblUsers.SingleOrDefault(b => b.Phone == HttpContext.Session.GetString("PhoneS") && b.Password == user.Password);
            if (Q != null)
            {
                var claims = new List<Claim>() {
                new Claim (ClaimTypes.NameIdentifier, Q.Id.ToString ()),
                new Claim (ClaimTypes.Name, Q.Phone)
                };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync(principal, properties);
                return RedirectToAction("index","home");
            }

            return View();

        }
    }
}