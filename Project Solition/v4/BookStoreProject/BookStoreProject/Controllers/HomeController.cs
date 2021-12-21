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
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(@"Data Source=OsmanPC;Initial Catalog=bookexchange;Integrated Security=True");
        public List<String> FetchCategories(string commandText)
        {
            try
            {
                List<String> categories = new List<string>();
                con.Open();
                com.Connection = con;
                com.CommandText = commandText;
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    categories.Add(dr["Book_Category"].ToString());
                }
                con.Close();
                return categories;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Book> FetchBook(string commandText)
        {
            List<Book> books = new List<Book>();
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = commandText;
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    books.Add(new Book()
                    {
                        ID = (Int64)dr["Book_ID"],
                        Name = dr["Book_Name"].ToString(),
                        Author = dr["Book_Author"].ToString(),
                        Category = dr["Book_Category"].ToString(),
                        PageCount = (int)dr["Book_PageCount"],
                        Price = (int)dr["Book_Price"],
                        Rating = (int)dr["Book_Rating"],
                        About = dr["Book_About"].ToString(),
                        Year = (int)dr["Book_Year"]
                    }) ;
                }
                con.Close();
                return books;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public IActionResult Index()
        {
            String comd = "SELECT TOP 12 * FROM[bookexchange].[dbo].[Book]";
            List<Book> books = FetchBook(comd);
            return View(books);
        }
        public IActionResult table_view()
        {
            String comd = "SELECT * FROM[bookexchange].[dbo].[Book]";
            List<Book> books = FetchBook(comd);
            return View(books);
        }
        public ActionResult Category()
        {
            string comd = "SELECT Book_Category FROM[bookexchange].[dbo].[Book] Group By Book_Category";
            List<String> categories = FetchCategories(comd);
            return View(categories);
        }
        [Route("book/{id:int}")]
        public ActionResult BookPage(int id)
        {
            string comd = "SELECT * FROM[bookexchange].[dbo].[Book] WHERE Book_ID ="+id;
            ViewBag.book = FetchBook(comd)[0];
            return View();
        }
        public ActionResult CheckOut()
        {
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
