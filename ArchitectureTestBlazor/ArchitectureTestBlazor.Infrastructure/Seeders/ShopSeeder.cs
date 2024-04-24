using ArchitectureTestBlazor.Domain;
using ArchitectureTestBlazor.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTestBlazor.Infrastructure.Seeders
{
    public class ShopSeeder
    {
        private readonly ShopDbContext _dbContext;
        public ShopSeeder(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Products.Any())
                {
                    var coffeeProduct = new Product() {
                        Name = "Coffee",
                        OriginCountry = "Africa"
                    };
                    _dbContext.Products.Add(coffeeProduct);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
