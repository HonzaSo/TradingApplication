using System.ComponentModel.DataAnnotations;
using TradingApplicationWeb.Interfaces;

namespace TradingApplicationWeb.Models
{
    public class FinancialProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Symbol { get; set; }
        [Required]
        public string From { get; set; }
        [Required]
        public double Open { get; set; }
        [Required]
        public double High { get; set; }
        [Required]
        public double Low { get; set; }
        [Required]
        public double Close { get; set; }
        [Required]
        public int Volume { get; set; }
    
    }
}
