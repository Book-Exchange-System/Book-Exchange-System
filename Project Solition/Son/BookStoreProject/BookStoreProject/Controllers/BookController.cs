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
        [Obsolete]
        SqlConnection con = HomeController.con;

        public static List<Book> shoppingCard = new List<Book>();
        [Route("book/{id:int}")]
        public ActionResult BookPage(int id)
        {
            string comd = "SELECT * FROM[bookexchange].[dbo].[Book] WHERE Book_ID =" + id;
            ViewBag.book = FetchBook(comd)[0];
            comd = "SELECT Top 10 * FROM [dbo].[Book] Order By Book_Rating Desc";
            List<Book> books = FetchBook(comd);
            ViewBag.FavoriteBooks = books;
            List<Book> trendyBooks = getTrendyBooks();
            ViewBag.trendyBooks = trendyBooks;
            if (LoginController.currentUser != null) ViewBag.ownedBooks = FetchBookWithStr(LoginController.currentUser.BooksOwned);
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

        [Route("readbook/{bookID}")]
        public IActionResult BookReader(String bookID)
        {
            if (LoginController.currentUser == null) RedirectToAction("login", "login");
            List<Book> ownedBooks = FetchBookWithStr(LoginController.currentUser.BooksOwned);
            foreach (Book book in ownedBooks)
            {
                if (book.ID.ToString() == bookID)
                {
                    return View(book);
                }
            }
            return Redirect(Request.Headers["Referer"].ToString());
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
            List<Book> books =new List<Book>();
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

        [Route("removeShoppingCart/{book_ID}")]
        public IActionResult RemoveShoppingCart(string book_ID)
        {
            
            for (int i = 0; i < shoppingCard.Count; i++)
            {
                if (shoppingCard[i].ID == Convert.ToInt32(book_ID))
                {
                    shoppingCard.RemoveAt(i);
                }
            }
            return Redirect(Request.Headers["Referer"].ToString());
        }

        [Route("addShoppingCart/{book_ID}")]
        public IActionResult AddShoppingCart(string book_ID)
        {
            if (LoginController.currentUser == null) return RedirectToAction("login", "login"); 
            List<Book> bookList = FetchBookWithStr(LoginController.currentUser.BooksOwned);
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].ID == Convert.ToInt32(book_ID))
                {
                    ViewBag.errorMessageShoppingCart = "You have already had this book!";
                    return RedirectToAction("index", "home");
                }
            }
            bool flag = true;
            for (int i = 0; i < shoppingCard.Count; i++)
            {
                if (shoppingCard[i].ID == Convert.ToInt32(book_ID))
                {
                    ViewBag.errorMessageShoppingCart = "This book has already been added to your shopping cart.";
                    flag = true;
                    return RedirectToAction("index", "home");
                }
            }
            if (flag)
            {
                Book newBook = getBook(book_ID);
                shoppingCard.Add(newBook);
                return Redirect(Request.Headers["Referer"].ToString());
            }
            return RedirectToAction("index", "home");
        }

        [Route("checkout")]
        public ActionResult CheckOut()
        {
            ViewBag.shoppingCard = shoppingCard;
            return View();
        }
        public List<Book> getTrendyBooks()
        {
            string cmd = "SELECT b.* FROM    Book b INNER JOIN Purchase p ON b.Book_ID=p.BookID GROUP BY b.Book_ID, b.Book_About,b.Book_Author,b.Book_Category,b.Book_Name,b.Book_PageCount,b.Book_year,b.Book_Price,b.Book_Rating Order by COUNT(b.Book_ID) desc";
            return FetchBook(cmd);
        }
        [Route("deletebook/{book_ID}")]
        public IActionResult DeleteBook(string book_ID)
        {
            string cmd = "Delete from [dbo].[Book] where Book_ID='" + book_ID + "';";
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = cmd;
            com.ExecuteNonQuery();
            con.Close();
            UserController userController = new UserController();
            List<User> users = userController.FetchUser("select * from [dbo].[User]");
            foreach(User user in users)
            {
                String newBooksOwned="";
                String temp = user.BooksOwned;
                if (temp.Contains(";"))
                {
                    String[] tempBooks = temp.Split(";");
                    if (tempBooks[0] != book_ID)
                    {
                        newBooksOwned = tempBooks[0];
                        for (int i = 1; i < tempBooks.Length; i++)
                        {
                            if (tempBooks[i] != book_ID) newBooksOwned += (";" + tempBooks[i]);
                        }
                    }
                    else
                    {
                        newBooksOwned = tempBooks[1];
                        for (int i = 2; i < tempBooks.Length; i++)
                        {
                            if (tempBooks[i] != book_ID) newBooksOwned += (";" + tempBooks[i]);
                        }
                    }
                }
                else if (temp.Length > 0)
                {
                    if (temp != book_ID) newBooksOwned = book_ID;
                }
                user.BooksOwned = newBooksOwned;
                String newReadAlreadyList = "";
                temp = user.ReadAlreadyList;
                if (temp.Contains(";"))
                {
                    String[] tempBooks = temp.Split(";");
                    if (tempBooks[0] != book_ID)
                    {
                        newReadAlreadyList = tempBooks[0];
                        for (int i = 1; i < tempBooks.Length; i++)
                        {
                            if (tempBooks[i] != book_ID) newReadAlreadyList += (";" + tempBooks[i]);
                        }
                    }
                    else
                    {
                        newReadAlreadyList = tempBooks[1];
                        for (int i = 2; i < tempBooks.Length; i++)
                        {
                            if (tempBooks[i] != book_ID) newReadAlreadyList += (";" + tempBooks[i]);
                        }
                    }
                }
                else if (temp.Length > 0)
                {
                    if (temp != book_ID) newReadAlreadyList = book_ID;
                }
                user.ReadAlreadyList = newReadAlreadyList;
                String newWantsToReadList = "";
                temp = user.WantsToReadList;
                if (temp.Contains(";"))
                {
                    String[] tempBooks = temp.Split(";");
                    if (tempBooks[0] != book_ID)
                    {
                        newWantsToReadList = tempBooks[0];
                        for (int i = 1; i < tempBooks.Length; i++)
                        {
                            if(tempBooks[i]!= book_ID) newWantsToReadList += (";" + tempBooks[i]);
                        }
                    }
                    else
                    {
                        newWantsToReadList = tempBooks[1];
                        for (int i = 2; i < tempBooks.Length; i++)
                        {
                            if (tempBooks[i] != book_ID) newWantsToReadList += (";" + tempBooks[i]);
                        }
                    }
                }
                else if (temp.Length > 0)
                {
                    if (temp != book_ID) newWantsToReadList = book_ID;
                }
                user.WantsToReadList = newWantsToReadList;
                if (user.NowReading == book_ID) user.NowReading = "";
                userController.UpdateUser(user);
            }
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }

}
