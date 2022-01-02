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
    public class UserController : Controller
    {
        BookController bookController = new BookController();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [Obsolete]
        SqlConnection con = HomeController.con;

        List<User> users = new List<User>();
        [Route("user/booktable/{type}")]
        public IActionResult DisplayBooks(string type)
        {
            List<Book> books = new List<Book>();
            if (type == "wantstoreadbooks")
            {
                books = bookController.FetchBookWithStr(LoginController.currentUser.WantsToReadList);
                ViewBag.bookType = "WantsToRead";
            }
            else if (type == "ownedbooks")
            {
                books = bookController.FetchBookWithStr(LoginController.currentUser.BooksOwned);
                ViewBag.bookType = "OwnedBook";
            }
            else if (type == "alreadyreadbooks")
            {
                books = bookController.FetchBookWithStr(LoginController.currentUser.ReadAlreadyList);
                ViewBag.bookType = "AlreadyReadBook";
            }
            ViewBag.isGuest = false;
            return View(books);
        }
        [Route("user/booktable/{userID:int}")]
        public IActionResult DisplayBooks(int userID)
        {
            String cmd = "select * from [dbo].[User] where ID='" + userID + "';";
            List<Book> books = books = bookController.FetchBookWithStr(FetchUser(cmd)[0].BooksOwned);
            ViewBag.bookType = "OwnedBook";
            ViewBag.isGuest = true;
            return View(books);
        }
        public List<User> FetchUser(String commandText)
        {

            if (users.Count > 0)
            {
                users.Clear();
            }
            try
            {
                
                con.Open();
                com.Connection = con;
                com.CommandText = commandText;
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    users.Add(new User()
                    {
                        ID = (Int64)dr["ID"],
                        Username = dr["Username"].ToString(),
                        Password = dr["Password"].ToString(),
                        Name = dr["Name"].ToString(),
                        Surname = dr["Surname"].ToString(),
                        Birthday = (DateTime)dr["Birthday"],
                        PhoneNumber = dr["PhoneNumber"].ToString(),
                        Email = dr["Email"].ToString(),
                        Gender = dr["Gender"].ToString(),
                        WantsToReadList = dr["WantsToReadList"].ToString(),
                        ReadAlreadyList = dr["ReadAlreadyList"].ToString(),
                        NowReading = dr["NowReading"].ToString(),
                        BooksOwned = dr["BooksOwned"].ToString(),
                        UserType = dr["UserType"].ToString(),
                        About = dr["About"].ToString(),
                        Facebook = dr["Facebook"].ToString(),
                        Twitter = dr["Twitter"].ToString(),
                        Youtube = dr["Youtube"].ToString(),
                        Pinterest = dr["Pinterest"].ToString(),
                    });
                }
                con.Close();
                return users;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void UpdateCurrentUser()
        {
            User user = LoginController.currentUser;
            String commandText = "Update [dbo].[User] Set Username = '" + user.Username + "', Name = '" + user.Name + "', Surname = '" + user.Surname + "', Password = '" + user.Password + "', Birthday = '" + user.Birthday.ToString("yyyy-MM-dd") + "', PhoneNumber = '" + user.PhoneNumber + "', Email = '" + user.Email + "', About = '" + user.About + "', Facebook = '" + user.Facebook + "', Twitter = '" + user.Twitter + "', Youtube = '" + user.Youtube + "', Pinterest = '" + user.Pinterest + "', BooksOwned = '" + user.BooksOwned + "', WantsToReadList = '" + user.WantsToReadList + "', ReadAlreadyList = '" + user.ReadAlreadyList + "', NowReading = '" + user.NowReading + "' where ID = '" + user.ID + "';";
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = commandText;
            com.ExecuteNonQuery();
            con.Close();
            LoginController.currentUser = FetchUser("select * from [dbo].[User] where ID = '"+ LoginController.currentUser.ID.ToString() + "';")[0];
        }
        [HttpGet]
        [Route("accountsettings")]
        public IActionResult AccountSettings()
        {
            User currentUser = LoginController.currentUser;
            if (currentUser != null)
            {
                ViewBag.user = LoginController.currentUser;
                return View();
            }
            else
            {
                return RedirectToAction("index", "home");
            }
        }
        [HttpPost]
        [Route("accountsettings")]
        public IActionResult AccountSettings(User user)
        {
            User currentUser = LoginController.currentUser;
            bool flag = false;
            if (user.Username != null && currentUser.Username != user.Username)
            {
                currentUser.Username = user.Username;
            }
            if (user.Name != null && currentUser.Name != user.Name)
            {
                currentUser.Name = user.Name;
            }
            if (user.Surname != null && currentUser.Surname != user.Surname)
            {
                currentUser.Surname = user.Surname;
            }
            if (user.PhoneNumber != null && currentUser.PhoneNumber != user.PhoneNumber)
            {
                currentUser.PhoneNumber = user.PhoneNumber;
            }
            if (currentUser.Birthday != user.Birthday)
            {
                currentUser.Birthday = user.Birthday;
            }
            if (user.About != null && currentUser.About != user.About)
            {
                currentUser.About = user.About;
            }
            if (user.Facebook != null && currentUser.Facebook != user.Facebook)
            {
                currentUser.Facebook = user.Facebook;
            }
            if (user.Twitter != null && currentUser.Twitter != user.Twitter)
            {
                currentUser.Twitter = user.Twitter;
            }
            if (user.Youtube != null && currentUser.Youtube != user.Youtube)
            {
                currentUser.Youtube = user.Youtube;
            }
            if (user.Pinterest != null && currentUser.Pinterest != user.Pinterest)
            {
                currentUser.Pinterest = user.Pinterest;
            }
            if (user.Password != null && currentUser.Password != user.Password)
            {
                currentUser.Password = user.Password;
                flag = true;
            }
            UpdateCurrentUser();
            if (flag)
            {
                return RedirectToAction("signout", "login");
            }
            else
            {
                ViewBag.updatedName = currentUser.Name;
                return RedirectToAction("index", "home");
            }
        }

        [Route("updatenowreadingbook/{bookID}")]
        public IActionResult UpdateNowReadingBook(String bookID)
        {
            LoginController.currentUser.NowReading = bookID;
            UpdateCurrentUser();
            return Redirect("~/user/" + LoginController.currentUser.Username);
        }

        [Route("donereadingbook/{bookID}")]
        public IActionResult DoneReading(String bookID)
        {
            LoginController.currentUser.NowReading = "";
            
            UpdateCurrentUser();
            AddToAlreadyReadList(bookID);
            return Redirect("~/user/" + LoginController.currentUser.Username);
        }
        [Route("updatewantstoreadlist/{bookID}")]
        public IActionResult DeleteFromWantsToReadList(String bookID)
        {
            string books= LoginController.currentUser.WantsToReadList;
            String temp = "";
            int counter = 0;
            List<Book> bookList = bookController.FetchBookWithStr(books);
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].ID == Convert.ToInt32(bookID))
                {
                    bookList.RemoveAt(i);
                    break;
                }
            }
            foreach (Book book in bookList)
            {
                if (counter == 0) temp += book.ID;
                else temp += (";" + book.ID);
                counter++;
            }
            LoginController.currentUser.WantsToReadList = temp;
            UpdateCurrentUser();
            return Redirect("~/user/booktable/wantstoreadbooks");
        }
        [Route("updatealreadyreadlist/{bookID}")]
        public IActionResult DeleteFromAlreadyReadList(String bookID)
        {
            string books = LoginController.currentUser.ReadAlreadyList;
            String temp = "";
            int counter = 0;
            List<Book> bookList = bookController.FetchBookWithStr(books);
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].ID == Convert.ToInt32(bookID))
                {
                    bookList.RemoveAt(i);
                    break;
                }
            }
            foreach (Book book in bookList)
            {
                if (counter == 0) temp += book.ID;
                else temp += (";" + book.ID);
                counter++;
            }
            LoginController.currentUser.ReadAlreadyList = temp;
            UpdateCurrentUser();
            return Redirect("~/user/booktable/alreadyreadbooks");
        }
        [Route("addtoalreadyreadlist/{bookID}")]
        public IActionResult AddToAlreadyReadList(String bookID)
        {
            string books = LoginController.currentUser.ReadAlreadyList;
            List<Book> bookList = bookController.FetchBookWithStr(books);
            foreach (Book book in bookList)
            {
                if(book.ID == Convert.ToInt32(bookID))
                {
                    return Redirect("~/user/booktable/ownedbooks");
                }
            }
            if (books.Length > 0) books += (";" + bookID);
            else books = bookID;
            LoginController.currentUser.ReadAlreadyList = books;
            UpdateCurrentUser();
            return Redirect("~/user/booktable/ownedbooks");
        }
        [Route("addtowantstoreadlist/{bookID}")]
        public IActionResult AddToWantsToReadList(String bookID)
        {
            if (LoginController.currentUser == null) return RedirectToAction("login", "login");
            string books = LoginController.currentUser.WantsToReadList;
            List<Book> bookList = bookController.FetchBookWithStr(books);
            foreach (Book book in bookList)
            {
                if (book.ID == Convert.ToInt32(bookID))
                {
                    return Redirect(Request.Headers["Referer"].ToString());
                }
            }
            if (books.Length > 0) books += (";" + bookID);
            else books = bookID;
            LoginController.currentUser.WantsToReadList = books;
            UpdateCurrentUser();
            return Redirect(Request.Headers["Referer"].ToString());
        }
        

        [Route("user/{username}")]
        public IActionResult UserProfile(string username)
        {
            User user = getUser(username);
            if (user != null)
            {
                ViewBag.nowReading = bookController.FetchBookWithStr(user.NowReading);
                ViewBag.wantsToReadList = bookController.FetchBookWithStr(user.WantsToReadList);
                ViewBag.booksOwned = bookController.FetchBookWithStr(user.BooksOwned);
                ViewBag.readAlreadyList = bookController.FetchBookWithStr(user.ReadAlreadyList);
                ViewBag.user = user;
                return View();
            }
            else
            {
                return RedirectToAction("index", "home");
            }
        }
        
        public User getUser(String username)
        {
            String commandText = "Select * from [bookexchange].[dbo].[User] where Username= '" + username + "'";
            FetchUser(commandText);
            foreach (User temp in users)
            {
                return temp;
            }
            return null;
        }
        public User CheckUser(User user)
        {
            String commandText = "Select * from [bookexchange].[dbo].[User] where Username= '"+ user.Username+"'";
            FetchUser(commandText);
            foreach (User temp in users)
            {
                if (temp.Password.Equals(user.Password)) return temp;
            }
            return null;
        }
        
        public bool HasUser(User user)
        {
            String commandText = "Select * from [bookexchange].[dbo].[User] where Username= '" + user.Username + "'";
            FetchUser(commandText);
            foreach(User temp in users)
            {
                if (temp.Username.Equals(user.Username)) return true;
            }
            return false;
        }
        
        public void AddUser(User user)
        {
            if (!HasUser(user))
            {
                String commandText= "insert into [dbo].[User](Username,Password,Name,Surname,Birthday,PhoneNumber,Email,Gender) values('" + user.Username + "','" + user.Password + "','" + user.Name +
                    "','" + user.Surname + "','" + user.Birthday.ToString("yyyy-MM-dd") + "','" + user.PhoneNumber.Replace("(","").Replace(")","").Replace(" ","") + "','" + user.Email + "','" + 
                    user.Gender+ "');";
                con.Open();
                com = con.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = commandText;
                com.ExecuteNonQuery();
                con.Close();
            }
        }




    }
}
