using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BTKAkademiWeb.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}