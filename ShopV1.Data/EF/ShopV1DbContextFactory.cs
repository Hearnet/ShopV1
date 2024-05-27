using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShopV1.Data.EF
{
    public class ShopV1DbContextFactory : IDesignTimeDbContextFactory<ShopV1DbContext>
    {
        public ShopV1DbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShopV1Db");

            var optionsBuilder = new DbContextOptionsBuilder<ShopV1DbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopV1DbContext(optionsBuilder.Options);
        }
    }
}
