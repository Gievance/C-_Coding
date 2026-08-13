using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form01.Models
{
    public class BookInfo
    {
        public int bookId { get; set; }
        public string bookName { get; set; }
        
        public string ToString()
        {
            return bookName;
        }
    }
}
