using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace BTKAkademiWeb.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.Product.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Get(int id)
        {
            var model = _manager.Product.GetOneProduct(id, false);
            return View(model);
        }
    }
}
