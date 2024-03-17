using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DemoShop.Data.Entities;

namespace DemoShop.Data.EF
{
    public class DemoShopDbContext : DbContext
    {
        public DemoShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}
