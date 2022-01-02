using BookStoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Controllers
{
    public class CategoryController : Controller
    {
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [Obsolete]
        SqlConnection con = HomeController.con;


        BookController bookController = new BookController();
        public List<String> FetchDataInView(String command,String table_name)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = command;
                List<String> data = new List<String>();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if(!data.Contains(dr[table_name].ToString())) data.Add(dr[table_name].ToString());
                }

                con.Close();
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [Route("category")]
        [Route("category/{searchText?}")]
        [HttpGet]
        public ActionResult Category(string searchText)
        {

            String comd = "";
            List<Book> allbooks = new List<Book>();
            if (searchText !=null&& searchText.Length > 0)
            {
                List<Book> tempBooks = new List<Book>();
                comd = "SELECT * FROM[bookexchange].[dbo].[Book]";
                allbooks = bookController.FetchBook(comd);
                foreach(Book book in allbooks)
                {
                    searchText = searchText.ToLower();
                    bool flag = false;
                    if (book.Name.ToLower().Contains(searchText)) flag = true;
                    else if (book.Author.ToLower().Contains(searchText)) flag = true;
                    else if (book.Category.ToLower().Contains(searchText)) flag = true;
                    else if (book.About.ToLower().Contains(searchText)) flag = true;
                    if (flag) tempBooks.Add(book);
                }
                allbooks = tempBooks;
            }
            else
            {
                comd = "SELECT * FROM[bookexchange].[dbo].[Book]";
                allbooks = bookController.FetchBook(comd);
            }
            ViewBag.CategoryBooks = allbooks;
            comd = "SELECT Top 10 * FROM [dbo].[Book] Order By Book_Rating Desc";
            List<Book> books = bookController.FetchBook(comd);
            ViewBag.FavoriteBooks = books;
                
            comd = "SELECT * FROM[bookexchange].[dbo].[Category]";
            List<String> categories = FetchDataInView(comd, "Book_Category");
            ViewBag.Categories = categories;
            comd = "SELECT * FROM[bookexchange].[dbo].[Year]";
            List<String> years = FetchDataInView(comd, "Book_Year");
            ViewBag.Years = years;
            comd = "SELECT * FROM[bookexchange].[dbo].[Author]";
            List<String> authors = FetchDataInView(comd, "Book_Author");
            ViewBag.Authors = authors;
            List<Book> trendyBooks = bookController.getTrendyBooks();
            ViewBag.trendyBooks = trendyBooks;
            return View();
        }
        [HttpPost]
        public ActionResult Category(Book book)
        {
            String comd = "SELECT * FROM [dbo].[Book]";
            List<Book> books = bookController.FetchBook(comd);
            List<Book> tempBooks = new List<Book>();
            foreach(Book tempbook in books)
            {
                bool flag = true;
                if (book.Category != "Category" && book.Category != tempbook.Category) flag = false;
                if (book.Author != "Author" && book.Author != tempbook.Author) flag = false;
                if (book.Year != 0 && book.Year != tempbook.Year) flag = false;
                if (flag) tempBooks.Add(tempbook);
            }
            ViewBag.CategoryBooks = tempBooks;
            comd = "SELECT Top 10 * FROM [dbo].[Book] Order By Book_Rating Desc";
            books = bookController.FetchBook(comd);
            ViewBag.FavoriteBooks = books;
            List<String> categories = FetchDataInView(comd, "Book_Category");
            ViewBag.Categories = categories;
            comd = "SELECT * FROM[bookexchange].[dbo].[Year]";
            List<String> years = FetchDataInView(comd, "Book_Year");
            ViewBag.Years = years;
            comd = "SELECT * FROM[bookexchange].[dbo].[Author]";
            List<String> authors = FetchDataInView(comd, "Book_Author");
            ViewBag.Authors = authors;
            List<Book> trendyBooks = bookController.getTrendyBooks();
            ViewBag.trendyBooks = trendyBooks;
            return View();
        }
    }
}
