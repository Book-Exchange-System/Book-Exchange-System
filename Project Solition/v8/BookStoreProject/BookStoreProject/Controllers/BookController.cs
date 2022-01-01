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
    public class BookController : Controller
    {
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(@"Data Source=OsmanPC;Initial Catalog=bookexchange;Integrated Security=True");

        [Route("book/{id:int}")]
        public ActionResult BookPage(int id)
        {
            string comd = "SELECT * FROM[bookexchange].[dbo].[Book] WHERE Book_ID =" + id;
            ViewBag.book = FetchBook(comd)[0];
            comd = "SELECT Top 10 * FROM [dbo].[Book] Order By Book_Rating Desc";
            List<Book> books = FetchBook(comd);
            ViewBag.FavoriteBooks = books;
            return View();
        }
        public Book getBook(String id)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT * FROM[bookexchange].[dbo].[Book] WHERE Book_ID = " + id;
                dr = com.ExecuteReader();
                Book book = null;
                while (dr.Read())
                {
                    book = new Book()
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
                    };
                }
                
                con.Close();
                return book;
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
                    });
                }
                con.Close();
                return books;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Book> FetchBookWithStr(string books_str)// books_str = "7"
        {
            List<Book> books = null;
            if (books_str.Contains(";"))
            {
                books = new List<Book>();
                string[] books_arr = books_str.Split(";");

                for (int i = 0; i < books_arr.Length; i++)
                {
                    string command = "SELECT * FROM[bookexchange].[dbo].[Book] WHERE Book_ID = " + books_arr[i];
                    books.Add(FetchBook(command)[0]);
                }
            }
            else if (books_str.Length>0)
            {
                string comd = "SELECT * FROM[bookexchange].[dbo].[Book] WHERE Book_ID =" + books_str;
                books = FetchBook(comd);

            }
            return books;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
