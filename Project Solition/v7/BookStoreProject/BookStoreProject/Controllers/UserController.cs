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
        SqlConnection con = new SqlConnection(@"Data Source=OsmanPC;Initial Catalog=bookexchange;Integrated Security=True");

        List<User> users = new List<User>();


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
            if (currentUser.About != user.About)
            {
                currentUser.About = user.About;
            }
            if (currentUser.Facebook != user.Facebook)
            {
                currentUser.Facebook = user.Facebook;
            }
            if (currentUser.Twitter != user.Twitter)
            {
                currentUser.Twitter = user.Twitter;
            }
            if (currentUser.Youtube != user.Youtube)
            {
                currentUser.Youtube = user.Youtube;
            }
            if (currentUser.Pinterest != user.Pinterest)
            {
                currentUser.Pinterest = user.Pinterest;
            }
            if (user.Password != null && currentUser.Password != user.Password)
            {
                currentUser.Password = user.Password;
                flag = true;
            }
            UpdateCurrentUser(currentUser);
            LoginController.currentUser = currentUser;
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
        public void UpdateCurrentUser(User user)
        {
            String commandText = "Update [dbo].[User] Set Username = '"+user.Username+"', Name = '" + user.Name + "', Surname = '" + user.Surname + "', Password = '" + user.Password + "', Birthday = '" + user.Birthday.ToString("yyyy-MM-dd") + "', PhoneNumber = '" + user.PhoneNumber + "', Email = '" + user.Email + "', About = '" + user.About + "', Facebook = '" + user.Facebook + "', Twitter = '" + user.Twitter + "', Youtube = '" + user.Youtube + "', Pinterest = '" + user.Pinterest + "' where ID = '"+user.ID+"';";
            con.Open();
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = commandText;
            com.ExecuteNonQuery();
            con.Close();
        }
        public IActionResult books_table()
        {
            String comd = "SELECT * FROM[bookexchange].[dbo].[Book]";
            List<Book> books = bookController.FetchBook(comd);
            return View(books);
        }
        
    }
}
