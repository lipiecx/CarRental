using CarRental.Models;
using CarRental.Models.CarRentalDb;
using CarRental.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test2()
        {
            // Setup
            string dbName = Guid.NewGuid().ToString();
            DbContextOptions<AppDbContext> options = new DbContextOptionsBuilder<AppDbContext>()
                            .UseInMemoryDatabase(databaseName: dbName).Options;

            // Seed
            using (AppDbContext dbContext = new AppDbContext(options))
            {
                ModelRepository modell = new ModelRepository(dbContext);
                
                modell.AddModel(new Model() {Brand = "toyota", Capacity = "100dm^3", Horsepower = 60 });
                Assert.Equal("toyota", modell.GetModel(1).Brand);
                Assert.Equal("100dm^3", modell.GetModel(1).Capacity);
                Assert.Equal(60, modell.GetModel(1).Horsepower);
            }
        }

    }
}
