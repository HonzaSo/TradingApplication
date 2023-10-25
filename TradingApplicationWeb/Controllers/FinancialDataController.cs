using Microsoft.AspNetCore.Mvc;
using TradingApplicationWeb.Data;
using TradingApplicationWeb.Interfaces;
using TradingApplicationWeb.Models;

namespace TradingApplicationWeb.Controllers
{
    public class FinancialDataController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IAccessDataOperation accessDataOperation;
        private readonly IDownloadDataController downloadDataController;
        public FinancialDataController(ApplicationDbContext dbContext, IAccessDataOperation accessDataOperation, IDownloadDataController downloadDataController)
        {
            this.dbContext = dbContext;
            this.accessDataOperation = accessDataOperation;
            this.downloadDataController = downloadDataController;
        }
        public IActionResult Index()
        {
            var financialProducts = accessDataOperation.GetAllFinancialProducts();

            return View(financialProducts);
        }
        public IActionResult Download()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string symbol, string from)
        {
            if (ModelState.IsValid)
            {
                var downloadedFinancialProduct = downloadDataController.DownloadDataForSymbolByDate(symbol.ToUpper(), from);
                if (downloadedFinancialProduct == null) {
                    TempData["empty"] = "Stazeni neprobehlo, zadal jsi spravne data?";

                } else
                {
                    TempData["success"] = "Stazeni bylo uspesne.";
                }
            }
            else
            {
                return View("Download", new FinancialProduct() { Symbol=symbol, From=from});
            }


            return RedirectToAction("Index", "FinancialData");
        }

        public IActionResult Buy()
        {
            return View();
        }

        public IActionResult Delete(FinancialProduct financialProduct)
        {
            accessDataOperation.DeleteProduct(financialProduct);
            TempData["success"] = "Smazani bylo uspesne.";
            return RedirectToAction("Index", "FinancialData");
        }
    }
}
