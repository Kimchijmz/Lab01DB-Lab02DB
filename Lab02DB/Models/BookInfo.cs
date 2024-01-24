using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02DB.Models
{
    class BookInfo
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Isbn13 { get; set; }
        public int StoreId { get; set; }
        public int StockBalance { get; set; }

    }
}
