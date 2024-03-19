using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoShop.Data.EF
{
    public class DemoShopDbContextFactory : IDesignTimeDbContextFactory<DemoShopDbContext>
    {
        public DemoShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DemoShopDb");
            var optionsBuilder = new DbContextOptionsBuilder<DemoShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DemoShopDbContext(optionsBuilder.Options);
        }
    }
}
