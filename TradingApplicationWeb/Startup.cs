using TradingApplicationWeb.Data;
using TradingApplicationWeb.Interfaces;
using TradingApplicationWebApi.Controllers;

namespace TradingApplicationWeb
{
    public class Startup
    {
        public IConfiguration configRoot { get; }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<IAccessDataOperation, AccessDataOperation>();
            services.AddScoped<IDownloadDataController, DownloadDataController>();
        }

    }
}
