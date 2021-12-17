using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public class User
    {
        public Int64 ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string[] WantsToReadList { get; set; }
        public string[] ReadAlreadyList { get; set; }
        public string[] NowReading { get; set; }
        public string[] BooksOwned { get; set; }
    }
}
