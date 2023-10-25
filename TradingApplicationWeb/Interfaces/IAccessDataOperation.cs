using TradingApplicationWeb.Models;

namespace TradingApplicationWeb.Interfaces
{
    public interface IAccessDataOperation
    {
        List<FinancialProduct> GetAllFinancialProducts();

        FinancialProduct? CreateProduct(FinancialProduct product);
        void DeleteProduct(FinancialProduct product);
        FinancialProduct? GetFinancialProductById(int id);
    }
}
