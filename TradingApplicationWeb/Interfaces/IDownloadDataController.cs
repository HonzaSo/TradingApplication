using TradingApplicationWeb.Models;

namespace TradingApplicationWeb.Interfaces
{
    public interface IDownloadDataController
    {
        FinancialProduct? DownloadDataForSymbolByDate(string symbol, string date);
    }
}
