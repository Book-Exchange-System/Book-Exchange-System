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

        SqlConnection con = new SqlConnection(@"Data Source=desktop-mruiip9;Initial Catalog=BookExchange;Integrated Security=True");
        public IActionResult Index()
        {
            return View();
        }
    }
}
