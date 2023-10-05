using Microsoft.AspNetCore.Mvc;

namespace BTKAkademiWeb.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
