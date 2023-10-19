﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using TradingApplicationWeb.Models;
using TradingApplicationWeb.Data;

namespace TradingApplicationWebApi.Controllers
{
    [ApiController]
    public class DownloadDataController : ControllerBase
    {
        private ApplicationDbContext _db { get; set; }
        public DownloadDataController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("API/DownloadData")]
        public FinancialProduct DownloadDataForSymbolByDate(string symbol, string date)
        {
            string finalyUrl = GetFinalyUrl(symbol, date);
            string response = DownloadData(finalyUrl);

            return SafeDataToDb(MapToFinancialProductModel(response));
        }

        private string GetFinalyUrl(string symbol, string date)
        {
            //string url = $"{_configuration["BaseUrlFY"]}/";
            //return $"{_configuration["BaseUrlFY"]}/" +
            //    $"{symbol}/{date}?adjusted=true&apiKey={_configuration["ApiKeyFY"]}";
            return "https://api.polygon.io/v1/open-close/" + symbol + "/" + date + "?adjusted=true&apiKey=UckwefeCsrNmdeIkoB7eQHLOSYc3E9kp";
        }

        private string DownloadData(string url)
        {
            HttpClient httpClient = new HttpClient();
            Task<string> ts = httpClient.GetStringAsync(url);
            return ts.Result;
        }

        private FinancialProduct MapToFinancialProductModel(string response)
        {
            FinancialProduct fp = JsonConvert.DeserializeObject<FinancialProduct>(response);
            return fp;
        }
        private FinancialProduct SafeDataToDb(FinancialProduct fp)
        {
            AccessDataOperation ado = new AccessDataOperation(_db);
            ado.CreateProduct(fp);
            return fp;
        }
    }
}