using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace BTKAkademiWeb.MVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IServiceManager _manager;

        public OrderController(IServiceManager manager)
        {
            _manager = manager;
        }
    }
}