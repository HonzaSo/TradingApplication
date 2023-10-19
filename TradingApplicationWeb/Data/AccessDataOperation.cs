using TradingApplicationWeb.Interfaces;
using TradingApplicationWeb.Models;

namespace TradingApplicationWeb.Data
{
    public class AccessDataOperation : IAccessDataOperation
    {
        private ApplicationDbContext _db { get; set; }
        public AccessDataOperation(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Delete(FinancialProduct product)
        {
            throw new NotImplementedException();
        }

        public List<FinancialProduct> GetAllFinancialProducts()
        {
            return _db.FinancialProducts.ToList();
        }

        public FinancialProduct GetFinancialProductById(int id)
        {
            throw new NotImplementedException();
        }

        public object SafeProduct(FinancialProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
