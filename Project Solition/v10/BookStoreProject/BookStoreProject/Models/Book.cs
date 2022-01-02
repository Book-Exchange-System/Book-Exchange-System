using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public class Book
    {
        public Int64 ID { get; set; }
        public String Name { get; set; }
        public String Author { get; set; }
        public String Category { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public String About { get; set; }
        public int Year { get; set; }
    }
}
