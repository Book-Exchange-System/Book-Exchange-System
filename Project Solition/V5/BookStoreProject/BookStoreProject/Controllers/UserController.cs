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


        public void FetchUser(String commandText)
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
                    });
                }
                con.Close();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public IActionResult user_table()
        {
            String commandText = "Select * from [bookexchange].[dbo].[User]";
            FetchUser(commandText);
            return View(users);
        }
        [Route("user/{username}")]
        [Obsolete]
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
