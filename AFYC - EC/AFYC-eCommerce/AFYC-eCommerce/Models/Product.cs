using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFYC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductImage { get; set; }

        private Product() {; }

        public Product(string ProductName, string ProductPrice, string ProductQuantity, string ProductImage)
        {

            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.ProductQuantity = ProductQuantity;
            this.ProductImage = ProductImage;
        }
    }
}