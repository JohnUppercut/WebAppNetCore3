using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KnifeContext db;

        public HomeController(ILogger<HomeController> logger, KnifeContext context)
        {
            _logger = logger;
            db = context;
        }
        public async Task<IActionResult> Test()
        {
            ViewBag.Knifes = await db.Knifes.ToListAsync();
            ViewBag.Users = await db.Users.ToListAsync();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Knife knife)
        {
            db.Knifes.Add(knife);
            await db.SaveChangesAsync();
            return RedirectToAction("Test");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public async Task<IActionResult> Shop()
        {
            return View(await db.Knifes.ToListAsync());
        }
        public async Task<IActionResult> ProductDetails()
        {
            ViewBag.Knifes = await db.Knifes.ToListAsync();
            ViewBag.Reviews = await db.Reviews.ToListAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductDetails(Review review)
        {
            review.Review_Date = DateTime.Now;
            db.Reviews.Add(review);
            await db.SaveChangesAsync();
            return RedirectToAction("ProductDetails");
        }
        
        public IActionResult LoginRegister()
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
