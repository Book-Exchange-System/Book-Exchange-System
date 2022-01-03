using BookStoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;

namespace BookStoreProject.Controllers
{
    [Obsolete]
    public class HomeController : Controller
    {

        BookController bookController = new BookController();
        public static SqlConnection con = new SqlConnection(@"Data Source=OsmanPC;Initial Catalog=bookexchange;Integrated Security=True");
        public IActionResult Index()
        {
            String comd = "SELECT TOP 12 * FROM[bookexchange].[dbo].[Book]";
            List<Book> books = bookController.FetchBook(comd);
            ViewBag.top12books = books;
            comd = "SELECT * FROM [dbo].[Book] where Book_ID=(select max(Book_ID)from Book)";
            books = bookController.FetchBook(comd);
            ViewBag.FeaturedBook = books[0];
            comd = "SELECT Top 10 * FROM [dbo].[Book] Order By Book_Rating Desc";
            books = bookController.FetchBook(comd);
            ViewBag.FavoriteBooks = books;
            List<Book> trendyBooks = bookController.getTrendyBooks();
            ViewBag.trendyBooks = trendyBooks;
            return View();
        }
        
        
        
       
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
