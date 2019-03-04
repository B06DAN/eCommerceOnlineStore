using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFYC.Models;
using AFYC_eCommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace AFYC.Controllers
{
    public class AdminController : Controller
    {


        private ApplicationDbContext db;


        public AdminController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [ActionName("GetProducts")]
        public void GetProducts()
        {
            var products = db.Product.ToList();
            ViewBag.Products = products;
        }

        public IActionResult AdminPanel()
        {
            GetProducts();
            return View();
        }
    }
}