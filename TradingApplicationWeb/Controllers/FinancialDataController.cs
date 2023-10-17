using Microsoft.AspNetCore.Mvc;
using TradingApplicationWeb.Data;
using TradingApplicationWeb.Models;

namespace TradingApplicationWeb.Controllers
{
    public class FinancialDataController : Controller
    {
        private readonly ApplicationDbContext _db;
        public FinancialDataController(ApplicationDbContext db)
        {
             _db = db;
        }
        public IActionResult Index()
        {
            List<FinancialProduct> objFinancialProductList = _db.FinancialProducts.ToList();
            return View(objFinancialProductList);
        }
    }
}
