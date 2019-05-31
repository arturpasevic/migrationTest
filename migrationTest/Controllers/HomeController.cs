using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using migrationTest.Models;

namespace migrationTest.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return Json(await _context.Phones.ToListAsync());
        }

        public async Task Create()
        {
            await _context.Phones.AddAsync(new Phone { Company = "Sams", Name = "wth", Price = 10 });
            await _context.Phones.AddAsync(new Phone { Company = "dkidkid", Name = "zxcvzxc", Price = 20 });

            await _context.SaveChangesAsync();
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
