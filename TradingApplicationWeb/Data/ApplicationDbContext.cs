using Microsoft.EntityFrameworkCore;
using TradingApplicationWeb.Models;

namespace TradingApplicationWeb.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<FinancialProduct> FinancialProducts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FinancialProduct>().HasData(
                new FinancialProduct { Id = 1, Symbol = "T", From = "2023-09-01", Open = 153.775, High = 154.33, Low = 150.42, Close = 150.87, Volume = 123456 },
                new FinancialProduct { Id = 2, Symbol = "E", From = "2023-09-01", Open = 153.775, High = 154.33, Low = 150.42, Close = 150.87, Volume = 123456 },
                new FinancialProduct { Id = 3, Symbol = "S", From = "2023-09-01", Open = 153.775, High = 154.33, Low = 150.42, Close = 150.87, Volume = 123456 }
                );
        }

    }

}
