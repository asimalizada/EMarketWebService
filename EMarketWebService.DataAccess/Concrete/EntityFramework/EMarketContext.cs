using EMarketWebService.Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace EMarketWebService.DataAccess.Concrete.EntityFramework
{
    public class EMarketContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = (localdb)\mssqlLocaldb; Database = EMarket; Trusted_connection=true"); // link
        }
    }
}
