using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorApp.Models
{
    public class Stock
    {
        public int ID { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public decimal Purchase{ get; set; }

        public decimal LastDiv { get; set; }
        
        public string Indestry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}