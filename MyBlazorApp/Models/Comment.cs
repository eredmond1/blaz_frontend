using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorApp.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int? StockID { get; set; }  // nav property
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public Stock? Stock { get; set; }
    }
}