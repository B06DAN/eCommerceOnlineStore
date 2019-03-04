using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AFYC_eCommerce.Models;
using AFYC_eCommerce.Data;
using AFYC.Models;

namespace AFYC_eCommerce.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext db;
        

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void GetProducts()
        {
            var products = db.Product.ToList();
            ViewBag.Products = products;
        }



        public IActionResult Index()
        {
            GetProducts();
            return View();
        }

        public IActionResult Category()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Favorite()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult ShoppingCart()
        {
            GetCartProducts();
            GetTotal();
            return View();
        }

        [HttpGet]
        [ActionName("GetCartProducts")]
        public void GetCartProducts()
        {
            var products = db.CartItem.ToList();

            ViewBag.CartProducts = products;
        }



        [HttpGet]
        [ActionName("GetTotal")]
        public void GetTotal()
        {
            var products = db.CartItem.ToList();
            float total = 0;
            var user = HttpContext.User.Identity.Name;
            foreach (CartItem prods in products)
            {
                if (prods.CartName == user)
                {
                    total += float.Parse(prods.ProductPrice.ToString());
                }
            }

            ViewBag.Total = total;
        }

        public IActionResult AdminPanel()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }







        public IActionResult ReturProduse()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult ModalitatiPlata()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult TermeniConditii()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
