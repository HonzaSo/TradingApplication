using System.ComponentModel.DataAnnotations;
using TradingApplicationWeb.Interfaces;

namespace TradingApplicationWeb.Models
{
    public class FinancialProduct
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Symbol produktu je vyzadovan.")]
        public string Symbol { get; set; }
        [Required(ErrorMessage = "Datum je povinny.")]
        //[RegularExpression("((?:19|20)\\d\\d)-(0?[1-9]|1[012])-([12][0-9]|3[01]|0?[1-9])")]
        public string From { get; set; }

        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public Int64 Volume { get; set; }
    
    }
}
