using BookStoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookStoreProject.Controllers
{
    public class LoginController : Controller
    {
        
        public static User currentUser { get; set; }
        UserController userController = new UserController();
        [Route("login")]
        [HttpGet]
        public IActionResult Login()
        {
            if(currentUser!=null) return RedirectToAction("index", "home");
            currentUser = null;
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            User temp = userController.CheckUser(user);
            if (temp!=null)
            {
                currentUser = temp;
                return RedirectToAction("index","home");
            }
            else
            {
                ViewBag.errorMessage = "*Wrong Username or Password!!!";
                return View();
            }
            
        }
        

        [HttpGet]
        public IActionResult Register() // bombos
        {
            if (currentUser != null) return RedirectToAction("index", "home");
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
        public IActionResult Signout()
        {
            currentUser = null;
            return RedirectToAction("index", "home");
        }
    }
}
