using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public class Purchase
    {
        public Int64 ID { get; set; }
        public Int64 BookID { get; set; }
        public Int64 UserID { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public string CardNumber { get; set; }
        public string CVC { get; set; }
        public string NameOnCard { get; set; }
        public string ExpireDateMonth { get; set; }
        public string ExpireDateYear { get; set; }

    }
}
