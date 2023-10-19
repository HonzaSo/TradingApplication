using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TradingApplicationWeb.Data;
using TradingApplicationWeb.Interfaces;
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
            AccessDataOperation ado = new AccessDataOperation(_db);
            List<FinancialProduct> lfp = ado.GetAllFinancialProducts();


            //List<FinancialProduct> objFinancialProductList = _db.FinancialProducts.ToList();
            return View(lfp);
            //return View(objFinancialProductList);
        }
        public IActionResult Download()
        {
            return View();
        }
    }
}
