using Microsoft.AspNetCore.Mvc;

namespace TradingApplicationWeb.Controllers
{
    public class FinancialDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
