using System.Numerics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AirLIine_MVC.Models;
using Models.Models;
using System.Globalization;

namespace Admin.Controllers
{
    [Area("Admin")]
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
            ViewBag.listcompany=_context.TblCompanies.ToList();
            var x=_context.TblPlans.ToList();
            List<PlanViewModel> f=new List<PlanViewModel>();
            foreach (var item in x)
            {
                PersianCalendar p = new PersianCalendar();
                string a = p.GetYear(item.tarikh).ToString() + "/" + p.GetMonth(item.tarikh).ToString() + "/" + p.GetDayOfWeek(item.tarikh).ToString();
                PlanViewModel g= new PlanViewModel()
                {
                    Id=item.Id,
                    Mabda=item.Mabda,
                    maghsad=item.maghsad,
                    Starikh= a,
                    Ssaat=item.tarikh.ToString("hh:mm:ss tt"),
                    NameAirline=item.NameAirline,
                    zarfiat=item.zarfiat
                };
                f.Add(g);
            }

            return View(f);
        }
        public IActionResult AddCompany()
        {
            ViewBag.list = _context.TblCompanies.ToList();
            if (m!=null)
            {
                ViewBag.m=m;
                m=null;
            }
            return View();
        }
        public IActionResult AddCompanies(CompanyViewModel company)
        {
            if (_context.TblCompanies.Any( a=> a.NameCompany==company.NameCompany))
            { 
                m="قبلا وارد شده است.";
            }
            else
            {
                TblCompany tbl = new TblCompany();
                tbl.NameCompany = company.NameCompany;
                _context.TblCompanies.Add(tbl);
                _context.SaveChanges();
            }

            return RedirectToAction("AddCompany");
        }
        public IActionResult AddPlans(PlanViewModel plan)
        {
            
            TblPlan tblPlan =new TblPlan()
            {
                Mabda=plan.Mabda,
                maghsad=plan.maghsad,
                tarikh=plan.tarikh,
                zarfiat=plan.zarfiat,
                NameAirline=plan.NameAirline
            };
            _context.TblPlans.Add(tblPlan);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult AddPlan()
        {
            ViewBag.l=_context.TblCompanies.ToList();
            return View();
        }


    }
}
