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
    public class LoginController : Controller
    {
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        SqlConnection con = new SqlConnection(@"Data Source=desktop-mruiip9;Initial Catalog=BookExchange;Integrated Security=True");

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult user_table()
        {
            List<User> users = new List<User>();
            if (users.Count > 0)
            {
                users.Clear();
            }
            try
            {
                String commandText = "Select * from [bookexchange].[dbo].[User]";
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
                        WantsToReadList = dr["WantsToReadList"].ToString().Split(";"),
                        ReadAlreadyList = dr["ReadAlreadyList"].ToString().Split(";"),
                        NowReading = dr["NowReading"].ToString().Split(";"),
                        BooksOwned = dr["BooksOwned"].ToString().Split(";"),

                    });
                }
                con.Close();
                
            }
            catch (Exception e)
            {
                throw e;
            }
            return View(users);
        }
    }
}
