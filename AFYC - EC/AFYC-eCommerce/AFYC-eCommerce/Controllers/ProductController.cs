using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFYC.Models;
using AFYC_eCommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFYC.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductsController : Controller
    {

        ApplicationDbContext db;

        public ProductsController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpPost]
        [ActionName("AddProduct")]
        public String AddProduct([FromBody] dynamic productToAdd)
        {
            try
            {
                String name = productToAdd[0]["value"].ToString();
                String price = productToAdd[1]["value"].ToString();
                String quantity = productToAdd[2]["value"].ToString();
                String image = "/images/" + productToAdd[3]["value"].ToString();


                Product product = new Product(name, price, quantity, image);
                db.Product.Add(product);
                db.SaveChanges();

                return "Ai adaugat un produs.";
        }
            catch (Exception e)
            {
                return e.ToString();
            }
}
        [HttpPost]
        [ActionName("Search")]
        public IEnumerable<Product> Search([FromBody] dynamic toSearch)
        {
            string search = toSearch[0]["value"].ToString();
            var products = db.Product.Where(s => s.ProductName.Contains(search)).ToList();
            return products.AsEnumerable();
        }

        [HttpDelete]
        [ActionName("RemoveProduct")]
        public String RemoveProduct([FromBody] dynamic productToRemove)
        {
            try
            {
                String name = productToRemove[0]["value"].ToString();

                var prod = db.Product.Where(product => product.ProductName == name).ToList().FirstOrDefault();
                if (prod != null)
                {
                    db.Product.Remove(prod);
                    db.SaveChanges();
                    return "Succes";
                }
                return "Product not found";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        [HttpPut]
        [ActionName("UpdateProduct")]
        public String UpdateProduct([FromBody] dynamic productToUpdate)
        {
            try
            {
                String currentName = productToUpdate[0]["value"].ToString();
                String name = productToUpdate[1]["value"].ToString();
                String price = productToUpdate[2]["value"].ToString();
                String quantity = productToUpdate[3]["value"].ToString();
                String image = "~/images/" + productToUpdate[4]["value"].ToString();

                var prod = db.Product.Where(product => product.ProductName == currentName).ToList().FirstOrDefault();
                if (prod != null)
                {
                    prod.ProductName = name;
                    prod.ProductPrice = price;
                    prod.ProductQuantity = quantity;
                    prod.ProductImage = image;

                    db.Product.Update(prod);
                    db.SaveChanges();
                    return "Succes";
                }
                return "Product not found";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        [HttpGet]
        [ActionName("GetProducts")]
        public void GetProducts()
        {
            var products = db.Product.ToList();

            ViewBag.Products = products;
        }
    }
}