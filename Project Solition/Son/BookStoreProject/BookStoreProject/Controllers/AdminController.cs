using BookStoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Controllers
{
    public class AdminController : Controller
    {
        User currentUser = LoginController.currentUser;
        BookController bookController = new BookController();
        UserController userController = new UserController();
        public IActionResult books_table()
        {
            String comd = "SELECT * FROM[bookexchange].[dbo].[Book]";
            List<Book> books = bookController.FetchBook(comd);
            if(currentUser!=null && currentUser.UserType != null && currentUser.UserType == "a")
            {
                return View(books);
            }
            return RedirectToAction("error", "home");
        }
        public IActionResult users_table()
        {
            String commandText = "Select * from [bookexchange].[dbo].[User]";
            List<User> users = userController.FetchUser(commandText);
            if (currentUser != null && currentUser.UserType !=null&&currentUser.UserType=="a")
            {
                return View(users);
            }
            return RedirectToAction("error", "home");
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            if (currentUser != null && currentUser.UserType != null && currentUser.UserType == "a")
            {
                return View();
            }
            return RedirectToAction("error", "home");
        }
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (currentUser != null && currentUser.UserType != null && currentUser.UserType == "a")
            {
                bookController.AddBook(book);
                return RedirectToAction("books_table", "admin");
            }
            return RedirectToAction("error", "home");
        }
    }
}
