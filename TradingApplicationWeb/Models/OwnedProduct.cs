using System.ComponentModel.DataAnnotations;

namespace TradingApplicationWeb.Models
{
    public class OwnedProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Symbol { get; set; }
        [Required]
        public double BuyingDate { get; set; }
        [Required]
        public int OwnedProductCount { get; set; }
        [Required]
        public double BuyingPrice { get; set; }
        public FinancialProduct FinancialProductId { get; set; }
    }
}
