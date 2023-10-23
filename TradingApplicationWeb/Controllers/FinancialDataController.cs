﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using TradingApplicationWeb.Data;
using TradingApplicationWeb.Interfaces;
using TradingApplicationWeb.Models;

namespace TradingApplicationWeb.Controllers
{
    public class FinancialDataController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IAccessDataOperation _ado;
        private readonly IDownloadDataController _ddc;
        public FinancialDataController(ApplicationDbContext db, IAccessDataOperation ado, IDownloadDataController ddc)
        {
            _db = db;
            _ado = ado;
            _ddc = ddc;
        }
        public IActionResult Index()
        {
            List<FinancialProduct> lfp = _ado.GetAllFinancialProducts();

            return View(lfp);
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
                _ddc.DownloadDataForSymbolByDate(symbol.ToUpper(), from);
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
    }
}
