using System;
using System.Collections.Generic;
using System.Text;
using AFYC.Models;
using AFYC_eCommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AFYC_eCommerce.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
    }
}
