using Microsoft.EntityFrameworkCore;
using TradingApplicationWeb.Models;

namespace TradingApplicationWeb.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        DbSet<FinancialProduct> FinancialProducts { get; set; }
    }

}
