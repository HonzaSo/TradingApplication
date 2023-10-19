﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Collections.Generic;
using TradingApplicationWeb.Data;
using TradingApplicationWeb.Interfaces;
using TradingApplicationWeb.Models;
using TradingApplicationWebApi.Controllers;

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

            return View(lfp);
        }
        public IActionResult Download()
        {
            return View();
        }

        //private FinancialProduct MapToFinancialProductModel(string response)
        //{
        //    DownloadDataController ddc = new DownloadDataController();
        //    FinancialProduct fp = JsonConvert.DeserializeObject<FinancialProduct>(response));
        //    return fp;
        //    //string downloadedData = DownloadDataForSymbolByDate();
        //}
        //private void SafeDataToDb()
        //{
            
        //}


    }
}
