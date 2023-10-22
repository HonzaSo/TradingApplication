using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using TradingApplicationWebApi;

namespace TradingApplicationWebApi.Controllers
{
    [ApiController]
    public class DownloadDataController2 : ControllerBase
    {
        //private readonly IConfiguration _configuration;
        //public DownloadDataController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        [HttpGet]
        [Route("API/DownloadData")]
        public string DownloadDataForSymbolByDate(string symbol, string date)
        {
            string finalyUrl = GetFinalyUrl(symbol, date);
            return DownloadData(finalyUrl);
        }

        private string GetFinalyUrl(string symbol, string date)
        {
            //string url = $"{_configuration["BaseUrlFY"]}/";
            //return $"{_configuration["BaseUrlFY"]}/" +
            //    $"{symbol}/{date}?adjusted=true&apiKey={_configuration["ApiKeyFY"]}";
            return "https://api.polygon.io/v1/open-close" + symbol + "/" + date + "?adjusted=true&apiKey=UckwefeCsrNmdeIkoB7eQHLOSYc3E9kp";
        }

        private string DownloadData(string url)
        {
            HttpClient httpClient = new HttpClient();
            Task<string> ts = httpClient.GetStringAsync(url);
            return ts.Result;
        }

        //private  FinancialProduct MapToFinancialProductModel(string response)
        //{
        //    DownloadDataController ddc = new DownloadDataController();
        //    FinancialProduct fp = JsonConvert.DeserializeObject<FinancialProduct>(response));
        //    return fp;
        //    //string downloadedData = DownloadDataForSymbolByDate();
        //}
        private void SafeDataToDb()
        {

        }
    }
}
