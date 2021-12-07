using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public class Book
    {
        String name;
        int number;
        public Book(String name,int number)
        {
            this.name = name;
            this.number = number;
        }
    }
}
