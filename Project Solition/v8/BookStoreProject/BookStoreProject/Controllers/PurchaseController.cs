using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Payment()
        {
            return View();
        }
    }
}
