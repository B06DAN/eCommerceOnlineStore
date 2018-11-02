using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AFYC_eCommerce.Models;

namespace AFYC_eCommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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

        public IActionResult Cart()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
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
