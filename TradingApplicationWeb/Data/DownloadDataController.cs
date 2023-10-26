using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TradingApplicationWeb.Models;
using TradingApplicationWeb.Data;
using TradingApplicationWeb.Interfaces;

namespace TradingApplicationWebApi.Controllers
{
    [ApiController]
    public class DownloadDataController : ControllerBase, IDownloadDataController
    {
        private ApplicationDbContext dbContext { get; set; }
        public DownloadDataController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        [Route("API/DownloadData")]
        public FinancialProduct? DownloadDataForSymbolByDate(string symbol, string date)
        {
            string finalyUrl = GetFinalyUrl(symbol, date);
            string response = DownloadData(finalyUrl);
            if (response == null)
            {
                return null;
            }
            return SaveDataToDb(MapToFinancialProductModel(response));
        }

        private string GetFinalyUrl(string symbol, string date)
        {
            return "https://api.polygon.io/v1/open-close/" + symbol + "/" + date + "?adjusted=true&apiKey=UckwefeCsrNmdeIkoB7eQHLOSYc3E9kp";
        }

        private string? DownloadData(string url)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                Task<string> ts = httpClient.GetStringAsync(url);
                return ts.Result;
            }
            catch
            {
                return null;
            }
        }

        private FinancialProduct MapToFinancialProductModel(string response)
        {
            FinancialProduct fp = JsonConvert.DeserializeObject<FinancialProduct>(response);
            return fp;
        }
        private FinancialProduct SaveDataToDb(FinancialProduct fp)
        {
            AccessDataOperation ado = new AccessDataOperation(dbContext);
            ado.CreateProduct(fp);
            return fp;
        }
    }
}
