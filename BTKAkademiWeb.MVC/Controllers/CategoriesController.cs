using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace BTKAkademiWeb.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        private IRepositoryManager _manager;

        public CategoriesController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.Category.FindAll(false);
            return View(model);
        }
    }
}
