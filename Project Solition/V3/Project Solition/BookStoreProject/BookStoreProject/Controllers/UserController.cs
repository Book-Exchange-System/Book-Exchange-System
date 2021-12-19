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
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        List<User> users = new List<User>();
        SqlConnection con = new SqlConnection(@"Data Source=desktop-mruiip9;Initial Catalog=BookExchange;Integrated Security=True");
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
        }
        public IActionResult user_table()
        {
            String commandText = "Select * from [bookexchange].[dbo].[User]";
            FetchUser(commandText);
            return View(users);
        }
        public bool CheckUser(User user)
        {
            String commandText = "Select * from [bookexchange].[dbo].[User]";
            FetchUser(commandText);
            foreach (User temp in users)
            {
                if (temp.Username.Equals(user.Username) && temp.Password.Equals(user.Password)) return true;
            }
            return false;
        }
        public bool HasUser(User user)
        {
            String commandText = "Select * from [bookexchange].[dbo].[User]";
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
