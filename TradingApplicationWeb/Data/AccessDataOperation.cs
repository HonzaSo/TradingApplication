using TradingApplicationWeb.Interfaces;
using TradingApplicationWeb.Models;

namespace TradingApplicationWeb.Data
{
    public class AccessDataOperation : IAccessDataOperation
    {
        private ApplicationDbContext dbContext { get; set; }
        public AccessDataOperation(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void DeleteProduct(FinancialProduct product)
        {
            dbContext.Remove(product);
            dbContext.SaveChanges();
        }

        public List<FinancialProduct> GetAllFinancialProducts()
        {
            return dbContext.FinancialProducts.ToList();
        }

        public FinancialProduct? GetFinancialProductById(int id)
        {
            return dbContext.FinancialProducts.FirstOrDefault(x => x.Id == id);
        }

        //TODO - vrace namapovaný nedatabazový objekt - souvisí s Modelem, který nebude navázaný na DB
        public FinancialProduct? CreateProduct(FinancialProduct product)
        {
            FinancialProduct? result = null;
            var financialProduct = dbContext.FinancialProducts.FirstOrDefault(x => x.Symbol == product.Symbol && x.From == product.From);
            if (financialProduct == null)
            {
                result = dbContext.Add(product).Entity;
                dbContext.SaveChanges();
            }

            return result;
        }
    }
}
