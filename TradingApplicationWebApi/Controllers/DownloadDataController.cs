using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace TradingApplicationWebApi.Controllers
{
    [ApiController]
    public class DownloadDataController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public DownloadDataController( IConfiguration configuration)
        {
            //_logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("API/DownloadData")]
        public string DownloadDataForSymbolByDate(string symbol, string date)
        {
            string finalyUrl = GetFinalyUrl(symbol, date);
            return DownloadData(finalyUrl);
        }

        private string GetFinalyUrl(string symbol, string date)
        {
            string url = $"{_configuration["BaseUrlFY"]}/";
            return $"{_configuration["BaseUrlFY"]}/" +
                $"{symbol}/{date}?adjusted=true&apiKey={_configuration["ApiKeyFY"]}";
        }

        private string DownloadData(string url)
        {
            HttpClient httpClient = new HttpClient();
            Task<string> ts = httpClient.GetStringAsync(url);
            return ts.Result;
        }


    }
}
