using BookStoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BookStoreProject.Controllers
{


    public class PurchaseController : Controller
    {



        BookController bookController = new BookController();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(@"Data Source=desktop-mruiip9;Initial Catalog=bookexchange;Integrated Security=True");

        List<User> users = new List<User>();

        [HttpGet]
        [Route("payment")]
        public IActionResult Payment()
        {
            List<Book> shoppingCard = BookController.shoppingCard;
            if (shoppingCard.Count != 0 && LoginController.currentUser!=null)
            {

                ViewBag.shoppingCard = shoppingCard;
                    return View(); 
            }
            else if (LoginController.currentUser == null && shoppingCard.Count != 0)
            {
                return RedirectToAction("login", "login");
            }
            else
            {
                return RedirectToAction("index", "home");
            }
            
        }

        [HttpPost]
        public IActionResult Payment(Purchase purchase)
        {
            String books = "";
            int counter = 0;
            foreach(Book book in BookController.shoppingCard)
            {
                if (counter == 0) books += book.ID;
                else books += (";" + book.ID);
                counter++;
                purchase.BookID = book.ID;
                purchase.Price = book.Price;
                purchase.Date = DateTime.Now;
                purchase.UserID = LoginController.currentUser.ID;
                string cmd = "INSERT into [dbo].[Purchase](BookID,UserID,Date,Price,CardNumber,CVC,NameOnCard,ExpireDate) values('"+purchase.BookID+"','"+ purchase.UserID + "','" + purchase.Date.ToString("yyyy-MM-dd") + "','" + purchase.Price + "','" + purchase.CardNumber + "','" + purchase.CVC + "','" + purchase.NameOnCard + "','" + (purchase.ExpireDateMonth + "/" + purchase.ExpireDateYear) + "');";
                con.Open();
                com = con.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = cmd;
                com.ExecuteNonQuery();
                con.Close();
            }
            if (LoginController.currentUser.BooksOwned.Length > 0)
            {
                LoginController.currentUser.BooksOwned += (";" + books);
            }
            else
            {
                LoginController.currentUser.BooksOwned = books;
            }
            UserController.UpdateCurrentUser();
            BookController.shoppingCard = new List<Book>();
            return RedirectToAction("index", "home");
        }
    }
}
