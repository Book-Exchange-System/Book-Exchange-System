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
        UserController userController = new UserController();
        [Route("login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (userController.CheckUser(user))
            {
                ViewBag.user = user;
                ViewBag.isLogin = true;
                return View("index");
            }
            else
            {
                String errorMessage = "";
                ViewBag.errorMessage = errorMessage;
                return View();
            }
            
        }
        [HttpGet] 
        public IActionResult Register() // bombos
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user) // formu doldurup submit ederse
        {
            if (ModelState.IsValid)
            {
                //database kayıt işlemleri
                if (!userController.HasUser(user))
                {
                    userController.AddUser(user);
                    return View("login");
                }
                else
                {
                    String errorMessage = "This username is already taken!";
                    ViewBag.errorMessage = errorMessage;
                    return View();
                }
            }
            else
            {
                return View();
            }
            
            
        }
    }
}
