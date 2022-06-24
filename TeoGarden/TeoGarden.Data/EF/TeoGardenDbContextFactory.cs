using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.Data.EF
{
    public class TeoGardenDbContextFactory : IDesignTimeDbContextFactory<TeoGardenDbContext>
    {
        public TeoGardenDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Default");

            var optionsBuilder = new DbContextOptionsBuilder<TeoGardenDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TeoGardenDbContext(optionsBuilder.Options);
        }
    }
}
