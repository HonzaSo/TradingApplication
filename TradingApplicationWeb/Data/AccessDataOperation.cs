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
            _db.Remove(product);
            _db.SaveChanges();
        }

        public List<FinancialProduct> GetAllFinancialProducts()
        {
            return _db.FinancialProducts.ToList();
        }

        public FinancialProduct GetFinancialProductById(int id)
        {
            return _db.FinancialProducts.FirstOrDefault(x => x.Id == id);
        }

        public object CreateProduct(FinancialProduct product)
        {
            object obj = null;
            FinancialProduct fp = _db.FinancialProducts.FirstOrDefault(x => x.Symbol == product.Symbol && x.From == product.From);
            if (fp == null)
            {
                obj = _db.Add(product);
                _db.SaveChanges();
            }

            return obj;
        }
    }
}
