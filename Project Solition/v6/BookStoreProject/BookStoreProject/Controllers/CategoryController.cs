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
        SqlConnection con = new SqlConnection(@"Data Source=OsmanPC;Initial Catalog=bookexchange;Integrated Security=True");


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
                    data.Add(dr[table_name].ToString());
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
        public ActionResult Category()
        {
            
            String comd = "SELECT Top 10 * FROM [dbo].[Book] Order By Book_Rating Desc";
            List<Book> books = bookController.FetchBook(comd);
            ViewBag.FavoriteBooks = books;
            comd = "SELECT * FROM[bookexchange].[dbo].[Category]";
            List<String> categories = FetchDataInView(comd,"Book_Category");
            ViewBag.Categories = categories;
            comd = "SELECT * FROM[bookexchange].[dbo].[Year]";
            List<String> years = FetchDataInView(comd,"Book_Year");
            ViewBag.Years = years;
            comd = "SELECT * FROM[bookexchange].[dbo].[Author]";
            List<String> authors = FetchDataInView(comd,"Book_Author");
            ViewBag.Authors = authors;
            return View();
        }
    }
}
